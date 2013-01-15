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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ChannelBox.Text != "" && ChannelBox.Text.StartsWith("#"))
            {
                Form1.ChannelJoin(ChannelBox.Text);
                Close();
            }
            else if (!ChannelBox.Text.StartsWith("#"))
            {
                MessageBox.Show("Please input a valid channel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Please enter a channel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChannelBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (ChannelBox.Text != "" && ChannelBox.Text.StartsWith("#"))
                {
                    Form1.ChannelJoin(ChannelBox.Text);
                    Close();
                }
                else if (!ChannelBox.Text.StartsWith("#"))
                {
                    MessageBox.Show("Please input a valid channel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please enter a channel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
