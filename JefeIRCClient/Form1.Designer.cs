namespace Arke
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Default");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Channels", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Queries");
            this.Channels = new System.Windows.Forms.TabControl();
            this.StatusPage = new System.Windows.Forms.TabPage();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.DefaultChannel = new System.Windows.Forms.TabPage();
            this.DefaultPartButton = new System.Windows.Forms.Button();
            this.DefaultChannelOutput = new System.Windows.Forms.RichTextBox();
            this.NickList = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.channelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinAChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partAChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.ChannelList = new System.Windows.Forms.TreeView();
            this.Channels.SuspendLayout();
            this.StatusPage.SuspendLayout();
            this.DefaultChannel.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Channels
            // 
            this.Channels.Controls.Add(this.StatusPage);
            this.Channels.Controls.Add(this.DefaultChannel);
            this.Channels.Location = new System.Drawing.Point(149, 36);
            this.Channels.Name = "Channels";
            this.Channels.SelectedIndex = 0;
            this.Channels.Size = new System.Drawing.Size(674, 631);
            this.Channels.TabIndex = 0;
            this.Channels.Selected += new System.Windows.Forms.TabControlEventHandler(this.Channels_Selected);
            // 
            // StatusPage
            // 
            this.StatusPage.Controls.Add(this.OutputBox);
            this.StatusPage.Controls.Add(this.TextBox);
            this.StatusPage.Location = new System.Drawing.Point(4, 22);
            this.StatusPage.Name = "StatusPage";
            this.StatusPage.Padding = new System.Windows.Forms.Padding(3);
            this.StatusPage.Size = new System.Drawing.Size(666, 605);
            this.StatusPage.TabIndex = 0;
            this.StatusPage.Text = "Status";
            this.StatusPage.UseVisualStyleBackColor = true;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(6, 7);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.ReadOnly = true;
            this.OutputBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.OutputBox.Size = new System.Drawing.Size(654, 566);
            this.OutputBox.TabIndex = 2;
            this.OutputBox.Text = "";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(6, 579);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(654, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // DefaultChannel
            // 
            this.DefaultChannel.Controls.Add(this.DefaultPartButton);
            this.DefaultChannel.Controls.Add(this.DefaultChannelOutput);
            this.DefaultChannel.Controls.Add(this.NickList);
            this.DefaultChannel.Controls.Add(this.textBox2);
            this.DefaultChannel.Location = new System.Drawing.Point(4, 22);
            this.DefaultChannel.Name = "DefaultChannel";
            this.DefaultChannel.Padding = new System.Windows.Forms.Padding(3);
            this.DefaultChannel.Size = new System.Drawing.Size(666, 605);
            this.DefaultChannel.TabIndex = 1;
            this.DefaultChannel.Text = "Channel";
            this.DefaultChannel.UseVisualStyleBackColor = true;
            // 
            // DefaultPartButton
            // 
            this.DefaultPartButton.Location = new System.Drawing.Point(533, 20);
            this.DefaultPartButton.Name = "DefaultPartButton";
            this.DefaultPartButton.Size = new System.Drawing.Size(113, 23);
            this.DefaultPartButton.TabIndex = 7;
            this.DefaultPartButton.Text = "Part Channel";
            this.DefaultPartButton.UseVisualStyleBackColor = true;
            // 
            // DefaultChannelOutput
            // 
            this.DefaultChannelOutput.Location = new System.Drawing.Point(6, 8);
            this.DefaultChannelOutput.Name = "DefaultChannelOutput";
            this.DefaultChannelOutput.ReadOnly = true;
            this.DefaultChannelOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.DefaultChannelOutput.Size = new System.Drawing.Size(502, 570);
            this.DefaultChannelOutput.TabIndex = 6;
            this.DefaultChannelOutput.Text = "";
            // 
            // NickList
            // 
            this.NickList.FormattingEnabled = true;
            this.NickList.Location = new System.Drawing.Point(518, 60);
            this.NickList.Name = "NickList";
            this.NickList.Size = new System.Drawing.Size(142, 537);
            this.NickList.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 582);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(502, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.channelToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // channelToolStripMenuItem
            // 
            this.channelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.joinAChannelToolStripMenuItem,
            this.partAChannelToolStripMenuItem});
            this.channelToolStripMenuItem.Name = "channelToolStripMenuItem";
            this.channelToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.channelToolStripMenuItem.Text = "Channel";
            // 
            // joinAChannelToolStripMenuItem
            // 
            this.joinAChannelToolStripMenuItem.Name = "joinAChannelToolStripMenuItem";
            this.joinAChannelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.joinAChannelToolStripMenuItem.Text = "Join a Channel";
            this.joinAChannelToolStripMenuItem.Click += new System.EventHandler(this.joinAChannelToolStripMenuItem_Click);
            // 
            // partAChannelToolStripMenuItem
            // 
            this.partAChannelToolStripMenuItem.Name = "partAChannelToolStripMenuItem";
            this.partAChannelToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.partAChannelToolStripMenuItem.Text = "Part a Channel";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Channels:";
            // 
            // ChannelList
            // 
            this.ChannelList.Location = new System.Drawing.Point(13, 65);
            this.ChannelList.Name = "ChannelList";
            treeNode1.Name = "DefaultChannel";
            treeNode1.Text = "Default";
            treeNode2.Name = "ActiveChannels";
            treeNode2.Text = "Channels";
            treeNode3.Name = "ActiveQueries";
            treeNode3.Text = "Queries";
            this.ChannelList.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            this.ChannelList.Size = new System.Drawing.Size(121, 602);
            this.ChannelList.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 679);
            this.Controls.Add(this.ChannelList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Channels);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Arke";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Channels.ResumeLayout(false);
            this.StatusPage.ResumeLayout(false);
            this.StatusPage.PerformLayout();
            this.DefaultChannel.ResumeLayout(false);
            this.DefaultChannel.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage StatusPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox TextBox;
        public System.Windows.Forms.TabControl Channels;
        private System.Windows.Forms.TabPage DefaultChannel;
        private System.Windows.Forms.ListBox NickList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RichTextBox DefaultChannelOutput;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem channelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinAChannelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partAChannelToolStripMenuItem;
        private System.Windows.Forms.TreeView ChannelList;
        private System.Windows.Forms.Button DefaultPartButton;
    }
}

