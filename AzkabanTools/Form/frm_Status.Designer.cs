
namespace AzkabanTools
{
    partial class frm_JobType
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_JobType));
            this.lsb_Dependency = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Config = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_JobInfo = new System.Windows.Forms.DataGridView();
            this.col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Property = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cms_Dgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_AddProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_JobStatus = new System.Windows.Forms.GroupBox();
            this.lbl_JobID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ss_JobStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_DBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pb_JobStatus = new System.Windows.Forms.PictureBox();
            this.lbl_JobStatus = new System.Windows.Forms.Label();
            this.lbl_JobDuration = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JobInfo)).BeginInit();
            this.cms_Dgv.SuspendLayout();
            this.grp_JobStatus.SuspendLayout();
            this.ss_JobStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_JobStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // lsb_Dependency
            // 
            this.lsb_Dependency.FormattingEnabled = true;
            this.lsb_Dependency.HorizontalScrollbar = true;
            this.lsb_Dependency.ItemHeight = 17;
            this.lsb_Dependency.Location = new System.Drawing.Point(7, 395);
            this.lsb_Dependency.Name = "lsb_Dependency";
            this.lsb_Dependency.Size = new System.Drawing.Size(272, 123);
            this.lsb_Dependency.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "依赖列表";
            // 
            // txt_Config
            // 
            this.txt_Config.Location = new System.Drawing.Point(7, 218);
            this.txt_Config.Multiline = true;
            this.txt_Config.Name = "txt_Config";
            this.txt_Config.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_Config.Size = new System.Drawing.Size(272, 151);
            this.txt_Config.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "配置信息";
            // 
            // dgv_JobInfo
            // 
            this.dgv_JobInfo.AllowUserToAddRows = false;
            this.dgv_JobInfo.AllowUserToDeleteRows = false;
            this.dgv_JobInfo.AllowUserToResizeColumns = false;
            this.dgv_JobInfo.AllowUserToResizeRows = false;
            this.dgv_JobInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_JobInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Name,
            this.col_Property});
            this.dgv_JobInfo.ContextMenuStrip = this.cms_Dgv;
            this.dgv_JobInfo.Location = new System.Drawing.Point(285, 12);
            this.dgv_JobInfo.MultiSelect = false;
            this.dgv_JobInfo.Name = "dgv_JobInfo";
            this.dgv_JobInfo.RowHeadersVisible = false;
            this.dgv_JobInfo.RowHeadersWidth = 51;
            this.dgv_JobInfo.RowTemplate.Height = 23;
            this.dgv_JobInfo.Size = new System.Drawing.Size(540, 507);
            this.dgv_JobInfo.TabIndex = 11;
            this.dgv_JobInfo.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_JobInfo_EditingControlShowing);
            // 
            // col_Name
            // 
            this.col_Name.HeaderText = "属性名";
            this.col_Name.MinimumWidth = 6;
            this.col_Name.Name = "col_Name";
            this.col_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.col_Name.Width = 125;
            // 
            // col_Property
            // 
            this.col_Property.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_Property.HeaderText = "属性值";
            this.col_Property.MinimumWidth = 6;
            this.col_Property.Name = "col_Property";
            this.col_Property.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.col_Property.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cms_Dgv
            // 
            this.cms_Dgv.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Dgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_AddProperty,
            this.tsmi_DeleteProperty});
            this.cms_Dgv.Name = "cms_Dgv";
            this.cms_Dgv.Size = new System.Drawing.Size(125, 48);
            // 
            // tsmi_AddProperty
            // 
            this.tsmi_AddProperty.Name = "tsmi_AddProperty";
            this.tsmi_AddProperty.Size = new System.Drawing.Size(124, 22);
            this.tsmi_AddProperty.Text = "增加属性";
            this.tsmi_AddProperty.Click += new System.EventHandler(this.tsmi_AddProperty_Click);
            // 
            // tsmi_DeleteProperty
            // 
            this.tsmi_DeleteProperty.Name = "tsmi_DeleteProperty";
            this.tsmi_DeleteProperty.Size = new System.Drawing.Size(124, 22);
            this.tsmi_DeleteProperty.Text = "删除属性";
            this.tsmi_DeleteProperty.Click += new System.EventHandler(this.tsmi_DeleteProperty_Click);
            // 
            // grp_JobStatus
            // 
            this.grp_JobStatus.BackColor = System.Drawing.SystemColors.Control;
            this.grp_JobStatus.Controls.Add(this.lbl_JobID);
            this.grp_JobStatus.Controls.Add(this.label6);
            this.grp_JobStatus.Controls.Add(this.ss_JobStatus);
            this.grp_JobStatus.Controls.Add(this.pb_JobStatus);
            this.grp_JobStatus.Controls.Add(this.lbl_JobStatus);
            this.grp_JobStatus.Controls.Add(this.lbl_JobDuration);
            this.grp_JobStatus.Controls.Add(this.label5);
            this.grp_JobStatus.Controls.Add(this.label2);
            this.grp_JobStatus.Location = new System.Drawing.Point(7, 12);
            this.grp_JobStatus.Name = "grp_JobStatus";
            this.grp_JobStatus.Size = new System.Drawing.Size(272, 180);
            this.grp_JobStatus.TabIndex = 12;
            this.grp_JobStatus.TabStop = false;
            this.grp_JobStatus.Text = "任务状态";
            // 
            // lbl_JobID
            // 
            this.lbl_JobID.AutoSize = true;
            this.lbl_JobID.Location = new System.Drawing.Point(96, 68);
            this.lbl_JobID.Name = "lbl_JobID";
            this.lbl_JobID.Size = new System.Drawing.Size(26, 17);
            this.lbl_JobID.TabIndex = 9;
            this.lbl_JobID.Text = "???";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "job ID：";
            // 
            // ss_JobStatus
            // 
            this.ss_JobStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.ss_JobStatus.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_JobStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_DBStatus});
            this.ss_JobStatus.Location = new System.Drawing.Point(3, 19);
            this.ss_JobStatus.Name = "ss_JobStatus";
            this.ss_JobStatus.Size = new System.Drawing.Size(266, 22);
            this.ss_JobStatus.TabIndex = 7;
            this.ss_JobStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(80, 17);
            this.toolStripStatusLabel1.Text = "数据库状态：";
            // 
            // tssl_DBStatus
            // 
            this.tssl_DBStatus.BackColor = System.Drawing.Color.Red;
            this.tssl_DBStatus.Name = "tssl_DBStatus";
            this.tssl_DBStatus.Size = new System.Drawing.Size(44, 17);
            this.tssl_DBStatus.Text = "未连接";
            // 
            // pb_JobStatus
            // 
            this.pb_JobStatus.Image = global::AzkabanTools.Properties.Resources.gray;
            this.pb_JobStatus.Location = new System.Drawing.Point(175, 102);
            this.pb_JobStatus.Name = "pb_JobStatus";
            this.pb_JobStatus.Size = new System.Drawing.Size(25, 25);
            this.pb_JobStatus.TabIndex = 6;
            this.pb_JobStatus.TabStop = false;
            // 
            // lbl_JobStatus
            // 
            this.lbl_JobStatus.AutoSize = true;
            this.lbl_JobStatus.Location = new System.Drawing.Point(96, 104);
            this.lbl_JobStatus.Name = "lbl_JobStatus";
            this.lbl_JobStatus.Size = new System.Drawing.Size(26, 17);
            this.lbl_JobStatus.TabIndex = 5;
            this.lbl_JobStatus.Text = "???";
            // 
            // lbl_JobDuration
            // 
            this.lbl_JobDuration.AutoSize = true;
            this.lbl_JobDuration.Location = new System.Drawing.Point(96, 140);
            this.lbl_JobDuration.Name = "lbl_JobDuration";
            this.lbl_JobDuration.Size = new System.Drawing.Size(26, 17);
            this.lbl_JobDuration.TabIndex = 4;
            this.lbl_JobDuration.Text = "???";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "job耗时：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "job状态：";
            // 
            // frm_JobType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 530);
            this.Controls.Add(this.grp_JobStatus);
            this.Controls.Add(this.dgv_JobInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Config);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lsb_Dependency);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frm_JobType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Job状态";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_JobType_FormClosing);
            this.Load += new System.EventHandler(this.frm_JobType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_JobInfo)).EndInit();
            this.cms_Dgv.ResumeLayout(false);
            this.grp_JobStatus.ResumeLayout(false);
            this.grp_JobStatus.PerformLayout();
            this.ss_JobStatus.ResumeLayout(false);
            this.ss_JobStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_JobStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lsb_Dependency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Config;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_JobInfo;
        private System.Windows.Forms.GroupBox grp_JobStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_JobStatus;
        private System.Windows.Forms.Label lbl_JobDuration;
        private System.Windows.Forms.PictureBox pb_JobStatus;
        private System.Windows.Forms.Label lbl_JobID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip ss_JobStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_DBStatus;
        private System.Windows.Forms.ContextMenuStrip cms_Dgv;
        private System.Windows.Forms.ToolStripMenuItem tsmi_AddProperty;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteProperty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Property;
    }
}