using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace com.xu81.dotnet.gplusplus
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void miExit_Click(object sender, EventArgs e)
        {
            AppController.AppExit();
        }

        private void miView_Click(object sender, EventArgs e)
        {
            if (this.Visible)
                this.Hide();
            else
                this.Show();
            this.miView.Text = this.Visible ? "隐藏" : "显示";
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            miView_Click(sender, e);
        }

        private void miOption_Click(object sender, EventArgs e)
        {
            new OptionForm().Show();
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //AppController.getActivities();
        }
    }
}
