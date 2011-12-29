namespace com.xu81.dotnet.gplusplus
{
    partial class OptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveAuth = new System.Windows.Forms.Button();
            this.btnGetAuth = new System.Windows.Forms.Button();
            this.txtAuthcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFileChooser = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbAutoRefreshAll = new System.Windows.Forms.CheckBox();
            this.txtRefreshDelay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveAuth);
            this.groupBox1.Controls.Add(this.btnGetAuth);
            this.groupBox1.Controls.Add(this.txtAuthcode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " 授权";
            // 
            // btnSaveAuth
            // 
            this.btnSaveAuth.AutoSize = true;
            this.btnSaveAuth.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveAuth.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSaveAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSaveAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAuth.Location = new System.Drawing.Point(289, 64);
            this.btnSaveAuth.Name = "btnSaveAuth";
            this.btnSaveAuth.Size = new System.Drawing.Size(65, 26);
            this.btnSaveAuth.TabIndex = 5;
            this.btnSaveAuth.Text = "验证Auth";
            this.btnSaveAuth.UseVisualStyleBackColor = false;
            this.btnSaveAuth.Click += new System.EventHandler(this.btnSaveAuth_Click);
            // 
            // btnGetAuth
            // 
            this.btnGetAuth.AutoSize = true;
            this.btnGetAuth.BackColor = System.Drawing.Color.LightGray;
            this.btnGetAuth.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnGetAuth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAuth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetAuth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetAuth.Location = new System.Drawing.Point(289, 22);
            this.btnGetAuth.Name = "btnGetAuth";
            this.btnGetAuth.Size = new System.Drawing.Size(65, 24);
            this.btnGetAuth.TabIndex = 4;
            this.btnGetAuth.Text = "获取Auth";
            this.btnGetAuth.UseVisualStyleBackColor = false;
            this.btnGetAuth.Click += new System.EventHandler(this.btnGetAuth_Click);
            // 
            // txtAuthcode
            // 
            this.txtAuthcode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAuthcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAuthcode.Location = new System.Drawing.Point(72, 66);
            this.txtAuthcode.Name = "txtAuthcode";
            this.txtAuthcode.Size = new System.Drawing.Size(211, 21);
            this.txtAuthcode.TabIndex = 3;
            this.txtAuthcode.Enter += new System.EventHandler(this.txtEnterChange);
            this.txtAuthcode.Leave += new System.EventHandler(this.txtLeaveRestore);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "AuthID:";
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtUserid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserid.Location = new System.Drawing.Point(72, 24);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.Size = new System.Drawing.Size(211, 21);
            this.txtUserid.TabIndex = 1;
            this.txtUserid.Enter += new System.EventHandler(this.txtEnterChange);
            this.txtUserid.Leave += new System.EventHandler(this.txtLeaveRestore);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFileChooser);
            this.groupBox2.Controls.Add(this.txtFilePath);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbAutoRefreshAll);
            this.groupBox2.Controls.Add(this.txtRefreshDelay);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能";
            // 
            // btnFileChooser
            // 
            this.btnFileChooser.AutoSize = true;
            this.btnFileChooser.BackColor = System.Drawing.Color.LightGray;
            this.btnFileChooser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFileChooser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFileChooser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnFileChooser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFileChooser.Location = new System.Drawing.Point(289, 68);
            this.btnFileChooser.Name = "btnFileChooser";
            this.btnFileChooser.Size = new System.Drawing.Size(65, 24);
            this.btnFileChooser.TabIndex = 5;
            this.btnFileChooser.Text = "选择";
            this.btnFileChooser.UseVisualStyleBackColor = false;
            this.btnFileChooser.Click += new System.EventHandler(this.btnFileChooser_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(108, 69);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(175, 21);
            this.txtFilePath.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "笔记保存路径:";
            // 
            // cbAutoRefreshAll
            // 
            this.cbAutoRefreshAll.AutoSize = true;
            this.cbAutoRefreshAll.Checked = true;
            this.cbAutoRefreshAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAutoRefreshAll.Location = new System.Drawing.Point(220, 29);
            this.cbAutoRefreshAll.Name = "cbAutoRefreshAll";
            this.cbAutoRefreshAll.Size = new System.Drawing.Size(72, 16);
            this.cbAutoRefreshAll.TabIndex = 2;
            this.cbAutoRefreshAll.Text = "自动刷新";
            this.cbAutoRefreshAll.UseVisualStyleBackColor = true;
            this.cbAutoRefreshAll.CheckedChanged += new System.EventHandler(this.cbAutoRefreshAll_CheckedChanged);
            // 
            // txtRefreshDelay
            // 
            this.txtRefreshDelay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRefreshDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefreshDelay.Location = new System.Drawing.Point(108, 25);
            this.txtRefreshDelay.Name = "txtRefreshDelay";
            this.txtRefreshDelay.Size = new System.Drawing.Size(85, 21);
            this.txtRefreshDelay.TabIndex = 1;
            this.txtRefreshDelay.Enter += new System.EventHandler(this.txtEnterChange);
            this.txtRefreshDelay.Leave += new System.EventHandler(this.txtLeaveRestore);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "刷新时间(秒):";
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.BackColor = System.Drawing.Color.LightGray;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Location = new System.Drawing.Point(301, 240);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 24);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "应用";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.AutoSize = true;
            this.btnCancle.BackColor = System.Drawing.Color.LightGray;
            this.btnCancle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(220, 240);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 24);
            this.btnCancle.TabIndex = 3;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOk
            // 
            this.btnOk.AutoSize = true;
            this.btnOk.BackColor = System.Drawing.Color.LightGray;
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(139, 240);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 24);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // OptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(388, 274);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionForm";
            this.Text = "设置";
            this.Load += new System.EventHandler(this.OptionForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveAuth;
        private System.Windows.Forms.Button btnGetAuth;
        private System.Windows.Forms.TextBox txtAuthcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAutoRefreshAll;
        private System.Windows.Forms.TextBox txtRefreshDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFileChooser;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;

    }
}