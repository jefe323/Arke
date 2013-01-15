using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arke
{
    public partial class NameBox : Form
    {
        public NameBox()
        {
            InitializeComponent();
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (ServerBox.Text == "" || PortBox.Text == "" || RealNameBox.Text == "" || NickBox.Text == "" || ChannelBox.Text == "")
            {
                MessageBox.Show("Please fill out all the required sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Form1.connected != true)
                {
                    try
                    {
                        int port = Convert.ToInt32(PortBox.Text);
                        Form1.Connect(ServerBox.Text, port, RealNameBox.Text, NickBox.Text, PasswordBox.Text, ChannelBox.Text);
                        Form1.connected = true;
                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Please input a valid port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("You are already connected to a server, please disconnect first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
