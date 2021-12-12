
namespace AzkabanTools
{
    partial class frm_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.ss_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_DBStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_YAMLStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FlowPath = new System.Windows.Forms.TextBox();
            this.btn_SearchNode = new System.Windows.Forms.Button();
            this.grp_Init = new System.Windows.Forms.GroupBox();
            this.txt_RootProperty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grp_NodeSearch = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_LocateNode = new System.Windows.Forms.Button();
            this.txt_SearchNode = new System.Windows.Forms.TextBox();
            this.btn_NextNode = new System.Windows.Forms.Button();
            this.btn_PrevNode = new System.Windows.Forms.Button();
            this.tv_ShowNodes = new System.Windows.Forms.TreeView();
            this.cms_Nodes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmi_NewNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_RenameNode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_CopyNodeName = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NodeProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.ms_Main = new System.Windows.Forms.MenuStrip();
            this.tsmi_File = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ReadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_WriteFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_SaveAsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DB = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DBConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_DBConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Explain = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_Status.SuspendLayout();
            this.grp_Init.SuspendLayout();
            this.grp_NodeSearch.SuspendLayout();
            this.cms_Nodes.SuspendLayout();
            this.ms_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_Status
            // 
            this.ss_Status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tssl_DBStatus,
            this.tssl_YAMLStatus});
            this.ss_Status.Location = new System.Drawing.Point(0, 529);
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(782, 26);
            this.ss_Status.TabIndex = 8;
            this.ss_Status.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 20);
            this.toolStripStatusLabel1.Text = "数据库状态：";
            // 
            // tssl_DBStatus
            // 
            this.tssl_DBStatus.BackColor = System.Drawing.Color.Red;
            this.tssl_DBStatus.Name = "tssl_DBStatus";
            this.tssl_DBStatus.Size = new System.Drawing.Size(54, 20);
            this.tssl_DBStatus.Text = "未连接";
            // 
            // tssl_YAMLStatus
            // 
            this.tssl_YAMLStatus.Name = "tssl_YAMLStatus";
            this.tssl_YAMLStatus.Size = new System.Drawing.Size(270, 20);
            this.tssl_YAMLStatus.Text = "，共侦测到-1个Name,侦测到-1个Flow";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Flow文件路径：";
            // 
            // txt_FlowPath
            // 
            this.txt_FlowPath.BackColor = System.Drawing.Color.White;
            this.txt_FlowPath.Location = new System.Drawing.Point(6, 43);
            this.txt_FlowPath.Multiline = true;
            this.txt_FlowPath.Name = "txt_FlowPath";
            this.txt_FlowPath.ReadOnly = true;
            this.txt_FlowPath.Size = new System.Drawing.Size(250, 63);
            this.txt_FlowPath.TabIndex = 10;
            // 
            // btn_SearchNode
            // 
            this.btn_SearchNode.Location = new System.Drawing.Point(6, 26);
            this.btn_SearchNode.Name = "btn_SearchNode";
            this.btn_SearchNode.Size = new System.Drawing.Size(90, 45);
            this.btn_SearchNode.TabIndex = 11;
            this.btn_SearchNode.Text = "搜索节点";
            this.btn_SearchNode.UseVisualStyleBackColor = true;
            this.btn_SearchNode.Click += new System.EventHandler(this.btn_SearchNode_Click);
            // 
            // grp_Init
            // 
            this.grp_Init.Controls.Add(this.txt_RootProperty);
            this.grp_Init.Controls.Add(this.label4);
            this.grp_Init.Controls.Add(this.txt_FlowPath);
            this.grp_Init.Controls.Add(this.label1);
            this.grp_Init.Location = new System.Drawing.Point(12, 31);
            this.grp_Init.Name = "grp_Init";
            this.grp_Init.Size = new System.Drawing.Size(263, 312);
            this.grp_Init.TabIndex = 12;
            this.grp_Init.TabStop = false;
            this.grp_Init.Text = "初始化";
            // 
            // txt_RootProperty
            // 
            this.txt_RootProperty.BackColor = System.Drawing.Color.White;
            this.txt_RootProperty.Location = new System.Drawing.Point(6, 129);
            this.txt_RootProperty.Multiline = true;
            this.txt_RootProperty.Name = "txt_RootProperty";
            this.txt_RootProperty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_RootProperty.Size = new System.Drawing.Size(250, 177);
            this.txt_RootProperty.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Root属性：";
            // 
            // grp_NodeSearch
            // 
            this.grp_NodeSearch.Controls.Add(this.label3);
            this.grp_NodeSearch.Controls.Add(this.btn_LocateNode);
            this.grp_NodeSearch.Controls.Add(this.txt_SearchNode);
            this.grp_NodeSearch.Controls.Add(this.btn_NextNode);
            this.grp_NodeSearch.Controls.Add(this.btn_PrevNode);
            this.grp_NodeSearch.Controls.Add(this.btn_SearchNode);
            this.grp_NodeSearch.Location = new System.Drawing.Point(12, 349);
            this.grp_NodeSearch.Name = "grp_NodeSearch";
            this.grp_NodeSearch.Size = new System.Drawing.Size(261, 177);
            this.grp_NodeSearch.TabIndex = 13;
            this.grp_NodeSearch.TabStop = false;
            this.grp_NodeSearch.Text = "节点搜索";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "搜索名：";
            // 
            // btn_LocateNode
            // 
            this.btn_LocateNode.Location = new System.Drawing.Point(166, 26);
            this.btn_LocateNode.Name = "btn_LocateNode";
            this.btn_LocateNode.Size = new System.Drawing.Size(90, 45);
            this.btn_LocateNode.TabIndex = 16;
            this.btn_LocateNode.Text = "定位当前";
            this.btn_LocateNode.UseVisualStyleBackColor = true;
            this.btn_LocateNode.Click += new System.EventHandler(this.btn_LocateNode_Click);
            // 
            // txt_SearchNode
            // 
            this.txt_SearchNode.Location = new System.Drawing.Point(81, 83);
            this.txt_SearchNode.Name = "txt_SearchNode";
            this.txt_SearchNode.Size = new System.Drawing.Size(175, 27);
            this.txt_SearchNode.TabIndex = 15;
            // 
            // btn_NextNode
            // 
            this.btn_NextNode.Location = new System.Drawing.Point(166, 126);
            this.btn_NextNode.Name = "btn_NextNode";
            this.btn_NextNode.Size = new System.Drawing.Size(90, 45);
            this.btn_NextNode.TabIndex = 14;
            this.btn_NextNode.Text = "下一节点";
            this.btn_NextNode.UseVisualStyleBackColor = true;
            this.btn_NextNode.Click += new System.EventHandler(this.btn_NextNode_Click);
            // 
            // btn_PrevNode
            // 
            this.btn_PrevNode.Location = new System.Drawing.Point(6, 126);
            this.btn_PrevNode.Name = "btn_PrevNode";
            this.btn_PrevNode.Size = new System.Drawing.Size(90, 45);
            this.btn_PrevNode.TabIndex = 12;
            this.btn_PrevNode.Text = "上一节点";
            this.btn_PrevNode.UseVisualStyleBackColor = true;
            this.btn_PrevNode.Click += new System.EventHandler(this.btn_PrevNode_Click);
            // 
            // tv_ShowNodes
            // 
            this.tv_ShowNodes.ContextMenuStrip = this.cms_Nodes;
            this.tv_ShowNodes.LabelEdit = true;
            this.tv_ShowNodes.Location = new System.Drawing.Point(279, 54);
            this.tv_ShowNodes.Name = "tv_ShowNodes";
            this.tv_ShowNodes.Size = new System.Drawing.Size(491, 472);
            this.tv_ShowNodes.TabIndex = 14;
            this.tv_ShowNodes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tv_ShowNodes_MouseDown);
            // 
            // cms_Nodes
            // 
            this.cms_Nodes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cms_Nodes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NewNode,
            this.tsmi_DeleteNode,
            this.tsmi_RenameNode,
            this.tsmi_CopyNodeName,
            this.tsmi_NodeProperty});
            this.cms_Nodes.Name = "cms_ShowNodes";
            this.cms_Nodes.Size = new System.Drawing.Size(185, 124);
            // 
            // tsmi_NewNode
            // 
            this.tsmi_NewNode.Name = "tsmi_NewNode";
            this.tsmi_NewNode.Size = new System.Drawing.Size(184, 24);
            this.tsmi_NewNode.Text = "新建节点(&N)";
            this.tsmi_NewNode.Click += new System.EventHandler(this.tsmi_NewNode_Click);
            // 
            // tsmi_DeleteNode
            // 
            this.tsmi_DeleteNode.Name = "tsmi_DeleteNode";
            this.tsmi_DeleteNode.Size = new System.Drawing.Size(184, 24);
            this.tsmi_DeleteNode.Text = "删除节点(&D)";
            this.tsmi_DeleteNode.Click += new System.EventHandler(this.tsmi_DeleteNode_Click);
            // 
            // tsmi_RenameNode
            // 
            this.tsmi_RenameNode.Name = "tsmi_RenameNode";
            this.tsmi_RenameNode.Size = new System.Drawing.Size(184, 24);
            this.tsmi_RenameNode.Text = "重命名(&R)";
            this.tsmi_RenameNode.Click += new System.EventHandler(this.tsmi_RenameNode_Click);
            // 
            // tsmi_CopyNodeName
            // 
            this.tsmi_CopyNodeName.Name = "tsmi_CopyNodeName";
            this.tsmi_CopyNodeName.Size = new System.Drawing.Size(184, 24);
            this.tsmi_CopyNodeName.Text = "复制Node名(&C)";
            this.tsmi_CopyNodeName.Click += new System.EventHandler(this.tsmi_CopyNodeName_Click);
            // 
            // tsmi_NodeProperty
            // 
            this.tsmi_NodeProperty.Name = "tsmi_NodeProperty";
            this.tsmi_NodeProperty.Size = new System.Drawing.Size(184, 24);
            this.tsmi_NodeProperty.Text = "Node属性(&P)";
            this.tsmi_NodeProperty.Click += new System.EventHandler(this.tsmi_NodeProperty_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Flow节点树结构";
            // 
            // ms_Main
            // 
            this.ms_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_File,
            this.tsmi_DB,
            this.tsmi_Explain});
            this.ms_Main.Location = new System.Drawing.Point(0, 0);
            this.ms_Main.Name = "ms_Main";
            this.ms_Main.Size = new System.Drawing.Size(782, 28);
            this.ms_Main.TabIndex = 16;
            // 
            // tsmi_File
            // 
            this.tsmi_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NewFile,
            this.tsmi_ReadFile,
            this.tsmi_WriteFile,
            this.tsmi_SaveAsFile});
            this.tsmi_File.Name = "tsmi_File";
            this.tsmi_File.Size = new System.Drawing.Size(71, 24);
            this.tsmi_File.Text = "文件(&F)";
            // 
            // tsmi_NewFile
            // 
            this.tsmi_NewFile.Name = "tsmi_NewFile";
            this.tsmi_NewFile.Size = new System.Drawing.Size(174, 26);
            this.tsmi_NewFile.Text = "新建文件(&N)";
            this.tsmi_NewFile.Click += new System.EventHandler(this.tsmi_NewFile_Click);
            // 
            // tsmi_ReadFile
            // 
            this.tsmi_ReadFile.Name = "tsmi_ReadFile";
            this.tsmi_ReadFile.Size = new System.Drawing.Size(174, 26);
            this.tsmi_ReadFile.Text = "读取文件(&R)";
            this.tsmi_ReadFile.Click += new System.EventHandler(this.tsmi_ReadFile_Click);
            // 
            // tsmi_WriteFile
            // 
            this.tsmi_WriteFile.Name = "tsmi_WriteFile";
            this.tsmi_WriteFile.Size = new System.Drawing.Size(174, 26);
            this.tsmi_WriteFile.Text = "保存文件(&S)";
            this.tsmi_WriteFile.Click += new System.EventHandler(this.tsmi_WriteFile_Click);
            // 
            // tsmi_SaveAsFile
            // 
            this.tsmi_SaveAsFile.Name = "tsmi_SaveAsFile";
            this.tsmi_SaveAsFile.Size = new System.Drawing.Size(174, 26);
            this.tsmi_SaveAsFile.Text = "另存为(&L)";
            this.tsmi_SaveAsFile.Click += new System.EventHandler(this.tsmi_SaveAsFile_Click);
            // 
            // tsmi_DB
            // 
            this.tsmi_DB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_DBConfig,
            this.tsmi_DBConnect});
            this.tsmi_DB.Name = "tsmi_DB";
            this.tsmi_DB.Size = new System.Drawing.Size(89, 24);
            this.tsmi_DB.Text = "数据库(&D)";
            // 
            // tsmi_DBConfig
            // 
            this.tsmi_DBConfig.Name = "tsmi_DBConfig";
            this.tsmi_DBConfig.Size = new System.Drawing.Size(171, 26);
            this.tsmi_DBConfig.Text = "连接设置(&S)";
            this.tsmi_DBConfig.Click += new System.EventHandler(this.tsmi_DBConfig_Click);
            // 
            // tsmi_DBConnect
            // 
            this.tsmi_DBConnect.Name = "tsmi_DBConnect";
            this.tsmi_DBConnect.Size = new System.Drawing.Size(171, 26);
            this.tsmi_DBConnect.Text = "连接(&C)";
            this.tsmi_DBConnect.Click += new System.EventHandler(this.tsmi_DBConnect_Click);
            // 
            // tsmi_Explain
            // 
            this.tsmi_Explain.Enabled = false;
            this.tsmi_Explain.Name = "tsmi_Explain";
            this.tsmi_Explain.Size = new System.Drawing.Size(105, 24);
            this.tsmi_Explain.Text = "软件说明(&H)";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tv_ShowNodes);
            this.Controls.Add(this.grp_NodeSearch);
            this.Controls.Add(this.grp_Init);
            this.Controls.Add(this.ss_Status);
            this.Controls.Add(this.ms_Main);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Azkaban工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ss_Status.ResumeLayout(false);
            this.ss_Status.PerformLayout();
            this.grp_Init.ResumeLayout(false);
            this.grp_Init.PerformLayout();
            this.grp_NodeSearch.ResumeLayout(false);
            this.grp_NodeSearch.PerformLayout();
            this.cms_Nodes.ResumeLayout(false);
            this.ms_Main.ResumeLayout(false);
            this.ms_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ss_Status;
        private System.Windows.Forms.ToolStripStatusLabel tssl_YAMLStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FlowPath;
        private System.Windows.Forms.Button btn_SearchNode;
        private System.Windows.Forms.GroupBox grp_Init;
        private System.Windows.Forms.GroupBox grp_NodeSearch;
        private System.Windows.Forms.Button btn_NextNode;
        private System.Windows.Forms.Button btn_PrevNode;
        private System.Windows.Forms.TextBox txt_SearchNode;
        private System.Windows.Forms.TreeView tv_ShowNodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cms_Nodes;
        private System.Windows.Forms.ToolStripMenuItem tsmi_CopyNodeName;
        private System.Windows.Forms.Button btn_LocateNode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_NodeProperty;
        private System.Windows.Forms.MenuStrip ms_Main;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DB;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DBConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DBConnect;
        private System.Windows.Forms.ToolStripMenuItem tsmi_Explain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssl_DBStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmi_File;
        private System.Windows.Forms.ToolStripMenuItem tsmi_NewFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_ReadFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_WriteFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_SaveAsFile;
        private System.Windows.Forms.ToolStripMenuItem tsmi_NewNode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_DeleteNode;
        private System.Windows.Forms.ToolStripMenuItem tsmi_RenameNode;
        private System.Windows.Forms.TextBox txt_RootProperty;
        private System.Windows.Forms.Label label4;
    }
}

