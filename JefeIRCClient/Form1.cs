using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using System.Threading;
using AccelIRC;

namespace Arke
{
    public partial class Form1 : Form
    {
        static IRCClient irc = new IRCClient("", "", "");
        static string channel;
        static string server;
        static int port;
        static string nick;
        static string realname;
        static string password;
        internal static bool connected = false;
        static Form1 instance;
        public static Form1 Instance { get { return instance; } }

        #region Some Override Methods
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            instance = this;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            instance = null;
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
            ChannelList.ExpandAll();
        }

        /*some random code I want to save for a bit...
         
         int count = Channels.TabCount;
         MessageBox.Show(count.ToString());
         Channels.TabPages.RemoveByKey("#jefe323");
         
         */

        public static void Connect(string uServer, int uPort, string uReal, string uNick, string uPassword, string uChannel)
        {
            server = uServer;
            port = uPort;
            realname = uReal;
            nick = uNick;
            password = uPassword;
            channel = uChannel;

            irc = new IRCClient(uNick, uNick, uReal);
            irc.AutoReconnect = true;

            irc.NumberMessageReceived += new IRCClient.NumberMessageReceivedHandler(irc_NumberMessageReceived);
            irc.ChannelMessage += new IRCClient.ChannelMessageHandler(irc_ChannelMessage);
            irc.ServerMessageReceived += new IRCClient.ServerMessageReceivedHandler(irc_ServerMessageReceived);

            irc.Connect(uServer, uPort);
            irc.JoinChannel(channel);
            instance.ChannelList.Nodes[0].Nodes[0].Text = channel;
            instance.DefaultChannel.Name = channel.ToString();
            instance.DefaultChannel.Text = channel.ToString();
        }

        //dynamically creates the new tab for a channel
        public static void ChannelJoin(string channelName)
        {
            var page = new TabPage(channelName);
            page.Name = channelName;
            instance.Channels.Controls.Add(page);
            //create the rtb
            var textbox = new RichTextBox();
            textbox.Name = channelName + "Output";
            textbox.Width = 502;
            textbox.Height = 570;
            textbox.Location = new Point(6, 8);
            textbox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            textbox.ReadOnly = true;
            page.Controls.Add(textbox);
            //create the textbox
            var inputBox = new TextBox();
            inputBox.Name = channelName + "Input";
            inputBox.Width = 502;
            inputBox.Height = 20;
            inputBox.Location = new Point(6, 582);
            inputBox.KeyPress += instance.textBox_KeyPress;
            page.Controls.Add(inputBox);
            //create the user list
            var listBox = new ListBox();
            listBox.Width = 142;
            listBox.Height = 537;
            listBox.Location = new Point(518,60);
            listBox.Name = channelName + "NickList";
            page.Controls.Add(listBox);
            //create the part button
            var button = new Button();
            button.Width = 113;
            button.Height = 23;
            button.Location = new Point(533,20);
            button.Text = "Part Channel";
            button.Name = channelName + "PartButton";
            page.Controls.Add(button);
            //add channel to list
            instance.ChannelList.Nodes[0].Nodes.Add(new TreeNode(channelName));
            //actually join the channel
            irc.SendRaw("JOIN " + channelName);
        }

        #region Printing Methods
        private delegate void printDelegate(string text);
        private void PrintTextStatus(string text)
        {
            if (OutputBox.InvokeRequired)
            {
                printDelegate pd = new printDelegate(PrintTextStatus);
                this.Invoke(pd, new object[] { text });
            }
            else
            {
                OutputBox.AppendText(text);
                OutputBox.SelectionStart = OutputBox.Text.Length;
                OutputBox.ScrollToCaret();
            }
        }

        private delegate void printChanDelegate(string text, bool ping, string channel);
        public void PrintTextChannel(string text, bool ping, string iChannel)
        {
            if (DefaultChannelOutput.InvokeRequired)
            {
                printChanDelegate pd = new printChanDelegate(PrintTextChannel);
                this.Invoke(pd, new object[] { text, ping, iChannel });
            }
            else
            {
                RichTextBox output = new RichTextBox();                   
                Type t = typeof(RichTextBox);
                foreach (TabPage page in instance.Channels.TabPages)
                {
                    foreach (Control ctrl in page.Controls)
                    {
                        if (ctrl.GetType() == t && ctrl.Name == iChannel + "Output")
                        {
                            output = (RichTextBox)ctrl;
                        }
                    }
                }

                if (output.Name != "")
                {
                    if (ping == true)
                    {
                        int length = output.TextLength;
                        System.Media.SystemSounds.Exclamation.Play();
                        output.AppendText(text);
                        output.SelectionStart = length;
                        output.SelectionLength = text.Length;
                        output.SelectionColor = Color.Red;
                        output.SelectionStart = output.Text.Length;
                        output.ScrollToCaret();
                    }
                    else
                    {
                        output.AppendText(text);
                        output.SelectionStart = output.Text.Length;
                        output.ScrollToCaret();
                    }
                }
                else
                {
                    if (ping == true)
                    {
                        int length = DefaultChannelOutput.TextLength;
                        System.Media.SystemSounds.Exclamation.Play();
                        DefaultChannelOutput.AppendText(text);
                        DefaultChannelOutput.SelectionStart = length;
                        DefaultChannelOutput.SelectionLength = text.Length;
                        DefaultChannelOutput.SelectionColor = Color.Red;
                        DefaultChannelOutput.SelectionStart = DefaultChannelOutput.Text.Length;
                        DefaultChannelOutput.ScrollToCaret();
                    }
                    else
                    {
                        DefaultChannelOutput.AppendText(text);
                        DefaultChannelOutput.SelectionStart = DefaultChannelOutput.Text.Length;
                        DefaultChannelOutput.ScrollToCaret();
                    }
                }
            }
        }

        private delegate void printServerDelegate(string text, string channel);
        public void PrintTextServerMsg(string text, string iChannel)
        {
            if (DefaultChannelOutput.InvokeRequired)
            {
                printServerDelegate pd = new printServerDelegate(PrintTextServerMsg);
                this.Invoke(pd, new object[] { text, iChannel });
            }
            else
            {
                RichTextBox output = new RichTextBox();
                Type t = typeof(RichTextBox);
                foreach (TabPage page in instance.Channels.TabPages)
                {
                    foreach (Control ctrl in page.Controls)
                    {
                        if (ctrl.GetType() == t && ctrl.Name == iChannel + "Output")
                        {
                            output = (RichTextBox)ctrl;
                        }
                    }
                }
                if (output.Name != "")
                {
                    int length = output.TextLength;
                    output.AppendText(text);
                    output.SelectionStart = length;
                    output.SelectionLength = text.Length;
                    output.SelectionColor = Color.Green;
                    output.SelectionStart = output.Text.Length;
                    output.ScrollToCaret();
                }
                else
                {
                    int length = DefaultChannelOutput.TextLength;
                    DefaultChannelOutput.AppendText(text);
                    DefaultChannelOutput.SelectionStart = length;
                    DefaultChannelOutput.SelectionLength = text.Length;
                    DefaultChannelOutput.SelectionColor = Color.Green;
                    DefaultChannelOutput.SelectionStart = DefaultChannelOutput.Text.Length;
                    DefaultChannelOutput.ScrollToCaret();
                }
            }
        }
        #endregion       

        #region IRC Events
        static void irc_ServerMessageReceived(string msg)
        {
            string[] args = msg.Split(' ');
            if (args[1].Contains("JOIN") && !msg.Contains("PRIVMSG"))
            {
                if (Form1.Instance != null)
                    Form1.Instance.PrintTextServerMsg(msg + Environment.NewLine, args[2]);
            }
            else if (args[1].Contains("PART") && !msg.Contains("PRIVMSG"))
            {
                MessageBox.Show(msg);
            }
            else if (args[1].Contains("QUIT") && !msg.Contains("PRIVMSG"))
            {
                if (Form1.Instance != null)
                    Form1.Instance.PrintTextServerMsg(msg + Environment.NewLine, args[2]);
            }
            else if (args[1].Contains("NICK") && !msg.Contains("PRIVMSG"))
            {
                if (Form1.Instance != null)
                    Form1.Instance.PrintTextServerMsg(msg + Environment.NewLine, args[2]);
            }
            /*if (!msg.Contains("PRIVMSG") && !msg.Contains("PONG"))
            {
                MessageBox.Show(msg);
            }*/
        }

        static void irc_ChannelMessage(object sender, AccelIRC.EventArgs.ChannelMessageEventArgs e)
        {
            DateTime time = DateTime.Now;
            if (e.Message.Contains(nick))
            {
                if (Form1.Instance != null)
                    Form1.Instance.PrintTextChannel("[" + time.ToShortTimeString() + "] <" + e.Nick + ">: " + e.Message + Environment.NewLine, true, e.Channel);
            }
            else
            {
                if (Form1.Instance != null)
                    Form1.Instance.PrintTextChannel("[" + time.ToShortTimeString() + "] <" + e.Nick + ">: " + e.Message + Environment.NewLine, false, e.Channel);
            }
        }

        static void irc_NumberMessageReceived(int number, string msg, string fullmsg)
        {
            if (Form1.Instance != null)
                Form1.Instance.PrintTextStatus(String.Format("{0} {1}", msg, Environment.NewLine));
        }
        #endregion

        #region Form Events
        //allows "enter" to be used to send text
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            DateTime time = DateTime.Now;
            TextBox txt = (TextBox)sender;
            if (e.KeyChar == '\r')
            {
                if (connected == true)
                {
                    e.Handled = true;                    
                    //add a check to make sure they are connected, else bad things happen
                    irc.SendMessage(instance.Channels.SelectedTab.Name, txt.Text);
                    if (Form1.Instance != null)
                        Form1.Instance.PrintTextChannel("[" + time.ToShortTimeString() + "] <" + nick + ">: " + txt.Text + Environment.NewLine, false, instance.Channels.SelectedTab.Name);
                    txt.Clear();
                }
                else
                {
                    txt.Clear();
                }
            }
        }

        //sets focus to the textbox when changing tabs
        private void Channels_Selected(object sender, TabControlEventArgs e)
        {
            //MessageBox.Show(e.TabPage.Name);
            Type t = typeof(TextBox);
            TextBox box = new TextBox();
            foreach (Control ctrl in e.TabPage.Controls)
            {
                if (ctrl.GetType() == t)
                {
                    box = (TextBox)ctrl;
                    if (box.CanFocus)
                    {
                        MessageBox.Show("true");
                        box.Focus();
                        box.Select(0, 0);
                    }
                    else
                    {
                        box.Select();
                    }
                }
            }
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            irc.NumberMessageReceived -= new IRCClient.NumberMessageReceivedHandler(irc_NumberMessageReceived);
            irc.ChannelMessage -= new IRCClient.ChannelMessageHandler(irc_ChannelMessage);
            irc.ServerMessageReceived -= new IRCClient.ServerMessageReceivedHandler(irc_ServerMessageReceived);
        }
        #endregion

        #region Menu Code
        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //initialize Form2
            NameBox connection = new NameBox();
            connection.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to disconnect from: " + server + "?";
            string caption = "Disconnect";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            MessageBoxIcon icon = MessageBoxIcon.Hand;
            DialogResult result;

            if (connected == true)
            {
                result = MessageBox.Show(message, caption, buttons, icon);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    irc.Disconnect();
                    connected = false;
                }
            }
            else
            {
                MessageBox.Show("You have to be connected to a server before you can disconnect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void joinAChannelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connected == true)
            {
                Form3 ChannelDialog = new Form3();
                ChannelDialog.Show();
                //open Form3 (channel)
            }
            else
            {
                MessageBox.Show("You have to be connected to a server before you can join a channel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
