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
    public partial class OptionForm : Form
    {
        public OptionForm()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbAutoRefreshAll_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox)
            {
                txtRefreshDelay.Enabled = ((CheckBox)sender).Checked;
            }
        }

        private void txtEnterChange(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = System.Drawing.Color.White;
            }
        }

        private void txtLeaveRestore(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                ((TextBox)sender).BackColor = System.Drawing.Color.WhiteSmoke;
            }
        }

        private void btnFileChooser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void btnGetAuth_Click(object sender, EventArgs e)
        {
            AppController.GetAuthCode();
        }

        private void btnSaveAuth_Click(object sender, EventArgs e)
        {
            string userid = txtUserid.Text.Trim();
            string authcode = txtAuthcode.Text.Trim();
            if (userid.Length != 0 && authcode.Length != 0)
            {
                AppController.userid = userid;
                AppController.authcode = authcode;
                if (AppController.VerifyAuthCode())
                    MessageBox.Show("验证成功");
            }
            else
            {
                MessageBox.Show("请输入用户ID和authID");
            }
            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string userid = txtUserid.Text.Trim();
            string authcode = txtAuthcode.Text.Trim();
            bool autoRefresh = cbAutoRefreshAll.Checked;
            string refreshDelay = txtRefreshDelay.Text.Trim();
            string notePath = txtFilePath.Text.Trim();
            if (userid.Length == 0)
            {
                MessageBox.Show("请输入用户ID");
                return;
            }
            if (authcode.Length == 0)
            {
                MessageBox.Show("请输入authID");
                return;
            }
            if (refreshDelay.Length == 0)
                refreshDelay = "0";
            Properties.Settings.Default.userid = userid;
            Properties.Settings.Default.authcode = authcode;
            Properties.Settings.Default.autorefresh = autoRefresh;
            Properties.Settings.Default.refreshdelay = Convert.ToInt16(refreshDelay);
            Properties.Settings.Default.notepath = notePath;
            AppController.authcode = authcode;
            AppController.userid = userid;
            AppController.autoRefresh = autoRefresh;
            AppController.refreshDelay = Convert.ToInt16(refreshDelay);
            AppController.notePath = notePath;
        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            txtAuthcode.Text = AppController.authcode;
            txtUserid.Text = AppController.userid;
            cbAutoRefreshAll.Checked = AppController.autoRefresh;
            txtRefreshDelay.Text = AppController.refreshDelay.ToString();
            txtFilePath.Text = AppController.notePath;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            AppController.getActivities();
        }
    }
}
