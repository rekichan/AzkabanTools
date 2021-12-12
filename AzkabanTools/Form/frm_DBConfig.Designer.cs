
namespace AzkabanTools
{
    partial class frm_DBConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DBConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HostName = new System.Windows.Forms.TextBox();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_SaveDBConfig = new System.Windows.Forms.Button();
            this.lsb_DB = new System.Windows.Forms.ListBox();
            this.grp_ConnectSetting = new System.Windows.Forms.GroupBox();
            this.chk_DBEnable = new System.Windows.Forms.CheckBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.grp_DataSource = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lsb_Table = new System.Windows.Forms.ListBox();
            this.grp_ConnectSetting.SuspendLayout();
            this.grp_DataSource.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "链接地址";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "端口号";
            // 
            // txt_HostName
            // 
            this.txt_HostName.Location = new System.Drawing.Point(91, 29);
            this.txt_HostName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_HostName.Name = "txt_HostName";
            this.txt_HostName.Size = new System.Drawing.Size(125, 27);
            this.txt_HostName.TabIndex = 2;
            this.txt_HostName.Text = "localhost";
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(91, 58);
            this.txt_Port.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(125, 27);
            this.txt_Port.TabIndex = 3;
            this.txt_Port.Text = "3306";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Font = new System.Drawing.Font("微软雅黑", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_Connect.Location = new System.Drawing.Point(455, 196);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(90, 45);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "链接数据库";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_SaveDBConfig
            // 
            this.btn_SaveDBConfig.Location = new System.Drawing.Point(224, 58);
            this.btn_SaveDBConfig.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_SaveDBConfig.Name = "btn_SaveDBConfig";
            this.btn_SaveDBConfig.Size = new System.Drawing.Size(90, 45);
            this.btn_SaveDBConfig.TabIndex = 6;
            this.btn_SaveDBConfig.Text = "保存设置";
            this.btn_SaveDBConfig.UseVisualStyleBackColor = true;
            this.btn_SaveDBConfig.Click += new System.EventHandler(this.btn_SaveDBConfig_Click);
            // 
            // lsb_DB
            // 
            this.lsb_DB.FormattingEnabled = true;
            this.lsb_DB.ItemHeight = 20;
            this.lsb_DB.Location = new System.Drawing.Point(6, 39);
            this.lsb_DB.Name = "lsb_DB";
            this.lsb_DB.Size = new System.Drawing.Size(211, 184);
            this.lsb_DB.TabIndex = 7;
            this.lsb_DB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsb_DB_MouseDoubleClick);
            // 
            // grp_ConnectSetting
            // 
            this.grp_ConnectSetting.BackColor = System.Drawing.SystemColors.Control;
            this.grp_ConnectSetting.Controls.Add(this.txt_UserName);
            this.grp_ConnectSetting.Controls.Add(this.label3);
            this.grp_ConnectSetting.Controls.Add(this.btn_SaveDBConfig);
            this.grp_ConnectSetting.Controls.Add(this.txt_HostName);
            this.grp_ConnectSetting.Controls.Add(this.label4);
            this.grp_ConnectSetting.Controls.Add(this.label1);
            this.grp_ConnectSetting.Controls.Add(this.txt_Password);
            this.grp_ConnectSetting.Controls.Add(this.label2);
            this.grp_ConnectSetting.Controls.Add(this.txt_Port);
            this.grp_ConnectSetting.Controls.Add(this.chk_DBEnable);
            this.grp_ConnectSetting.Location = new System.Drawing.Point(10, 8);
            this.grp_ConnectSetting.Name = "grp_ConnectSetting";
            this.grp_ConnectSetting.Size = new System.Drawing.Size(340, 155);
            this.grp_ConnectSetting.TabIndex = 8;
            this.grp_ConnectSetting.TabStop = false;
            this.grp_ConnectSetting.Text = "链接设置";
            // 
            // chk_DBEnable
            // 
            this.chk_DBEnable.AutoSize = true;
            this.chk_DBEnable.Location = new System.Drawing.Point(229, 118);
            this.chk_DBEnable.Name = "chk_DBEnable";
            this.chk_DBEnable.Size = new System.Drawing.Size(106, 24);
            this.chk_DBEnable.TabIndex = 13;
            this.chk_DBEnable.Text = "启用数据库";
            this.chk_DBEnable.UseVisualStyleBackColor = true;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(91, 87);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(125, 27);
            this.txt_UserName.TabIndex = 11;
            this.txt_UserName.Text = "root";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "用户名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "密码";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(91, 116);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(125, 27);
            this.txt_Password.TabIndex = 12;
            this.txt_Password.Text = "******";
            // 
            // grp_DataSource
            // 
            this.grp_DataSource.Controls.Add(this.label6);
            this.grp_DataSource.Controls.Add(this.label5);
            this.grp_DataSource.Controls.Add(this.lsb_Table);
            this.grp_DataSource.Controls.Add(this.lsb_DB);
            this.grp_DataSource.Location = new System.Drawing.Point(10, 189);
            this.grp_DataSource.Name = "grp_DataSource";
            this.grp_DataSource.Size = new System.Drawing.Size(440, 252);
            this.grp_DataSource.TabIndex = 9;
            this.grp_DataSource.TabStop = false;
            this.grp_DataSource.Text = "数据源设置";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "数据库选择";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据库选择";
            // 
            // lsb_Table
            // 
            this.lsb_Table.FormattingEnabled = true;
            this.lsb_Table.ItemHeight = 20;
            this.lsb_Table.Location = new System.Drawing.Point(223, 39);
            this.lsb_Table.Name = "lsb_Table";
            this.lsb_Table.Size = new System.Drawing.Size(211, 184);
            this.lsb_Table.TabIndex = 8;
            // 
            // frm_DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(362, 175);
            this.Controls.Add(this.grp_DataSource);
            this.Controls.Add(this.grp_ConnectSetting);
            this.Controls.Add(this.btn_Connect);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "frm_DBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azkaban数据库设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_DBConfig_FormClosing);
            this.Load += new System.EventHandler(this.frm_DBConfig_Load);
            this.grp_ConnectSetting.ResumeLayout(false);
            this.grp_ConnectSetting.PerformLayout();
            this.grp_DataSource.ResumeLayout(false);
            this.grp_DataSource.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HostName;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_SaveDBConfig;
        private System.Windows.Forms.ListBox lsb_DB;
        private System.Windows.Forms.GroupBox grp_ConnectSetting;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.GroupBox grp_DataSource;
        private System.Windows.Forms.ListBox lsb_Table;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chk_DBEnable;
    }
}