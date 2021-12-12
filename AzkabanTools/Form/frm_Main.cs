using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using Newtonsoft.Json.Linq;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Dynamic;

namespace AzkabanTools
{
    public partial class frm_Main : Form
    {

        #region Properties
        private delegate void callConnectDB();
        private List<TreeNode> searchTreeNodes;
        private int currentSelectedNode;
        private int nameCount;
        private int flowCount;
        private string dbEnable;
        #endregion

        #region Constructor
        public frm_Main()
        {
            InitializeComponent();
        }
        #endregion

        #region API
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, int lParam);
        #endregion

        #region FormEvent
        private void frm_Main_Load(object sender, EventArgs e)
        {
            cls_Msg.hwndFrmMain = this.Handle;

            string path = cls_Database.dbConfigPath;
            cls_Database.config = new cls_WRIni(path);
            cls_Database.hostName = cls_Database.config.IniReadValue("DBConfig", "HostName", "localhost");
            cls_Database.port = cls_Database.config.IniReadValue("DBConfig", "Port", "3306");
            cls_Database.userName = cls_Database.config.IniReadValue("DBConfig", "UserName", "root");
            cls_Database.password = cls_Database.config.IniReadValue("DBConfig", "Password", "******");
            dbEnable = cls_Database.config.IniReadValue("DBConfig", "DBEnable", "0");

            if ("1".Equals(dbEnable))
            {
                callConnectDB connectDB = new callConnectDB(ConnectDB);
                connectDB.BeginInvoke(null, null);
            }

            /*string connStr = string.Format("datasource={0};port={1};userid={2};pwd={3}", cls_Database.hostName, cls_Database.port, cls_Database.userName, cls_Database.password);
            try
            {
                cls_Database.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                cls_Database.conn.Open();
                tsmi_DBConnect.Text = "断开连接";
                tsmi_DBConnect.BackColor = Color.YellowGreen;
                tssl_DBStatus.Text = "已连接";
                tssl_DBStatus.BackColor = Color.Lime;
                cls_Database.linkStatus = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                cls_Logger.Instance.WriteExceptionLog(ex);
                cls_Database.linkStatus = false;
            }*/
        }
        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (cls_Database.conn != null)
                    cls_Database.conn.Close();
            }
            catch (Exception ex)
            {
                cls_Logger.Instance.WriteExceptionLog(ex);
            }
        }
        #endregion

        #region Function
        private void ConnectDB()
        {
            cls_Database.linking = true;
            string connStr = string.Format("datasource={0};port={1};userid={2};pwd={3}", cls_Database.hostName, cls_Database.port, cls_Database.userName, cls_Database.password);
            try
            {
                cls_Database.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                cls_Database.conn.Open();
                cls_Database.linkStatus = true;
                PostMess(cls_Msg.hwndFrmMain, cls_Msg.CONNECT_DB_FAIL);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                cls_Logger.Instance.WriteExceptionLog(ex);
                cls_Database.linkStatus = false;
                PostMess(cls_Msg.hwndFrmMain, cls_Msg.CONNECT_DB_FAIL);
            }
        }

        private void DisplayTreeView(JToken root, string rootName)
        {
            tv_ShowNodes.BeginUpdate();
            try
            {
                tv_ShowNodes.Nodes.Clear();
                var tNode = tv_ShowNodes.Nodes[tv_ShowNodes.Nodes.Add(new TreeNode(rootName))];
                tNode.Tag = root;
                AddNode(root, tNode);
                tv_ShowNodes.ExpandAll();
            }
            finally
            {
                tv_ShowNodes.EndUpdate();
            }
        }

        private void AddNode(JToken token, TreeNode inTreeNode)
        {
            if (token == null)
                return;

            if (token is JValue && token.ToString() != "")
            {
                nameCount++;
                int tn = inTreeNode.Nodes.Add(new TreeNode(token.ToString()));
                //sub tag
                inTreeNode.Nodes[tn].Tag = token.Parent.Parent.ToString();
            }
            else if (token is JObject)
            {
                JObject obj = (JObject)token;
                foreach (JProperty property in obj.Properties())
                {
                    if ("name".Equals(property.Name.ToLower()) || "nodes".Equals(property.Name.ToLower()))
                    {
                        if (property.Next != null && "flow".Equals(property.Next.First.ToString().ToLower()))
                        {
                            //inTreeNode.Nodes[tn].Tag = token.Parent.Parent.ToString();
                            continue;
                        }
                        AddNode(property.Value, inTreeNode);
                    }
                }
            }
            else if (token is JArray)
            {
                JArray array = (JArray)token;
                for (int i = 0; i < array.Count; i++)
                {
                    TreeNode tn = inTreeNode;
                    JObject obj = (JObject)array[i];
                    if ("flow".Equals(obj.GetValue("type").ToString()) && obj.Previous != null)
                    {
                        nameCount++;
                        flowCount++;
                        tn = inTreeNode.Nodes[inTreeNode.Nodes.Add(new TreeNode(obj.GetValue("name").ToString()))];
                        //flow tag

                        tn.Tag = obj.First.Parent.ToString();
                    }
                    AddNode(array[i], tn);
                }
            }
            else
            {
                cls_Logger.Instance.WriteExceptionLog(new Exception("{0} element in JToken"));
            }
        }

        private void ResetBackcolor(TreeNode node)
        {
            node.BackColor = Color.White;
            node.ForeColor = Color.Black;
            if (node.Nodes.Count != 0)
            {
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    ResetBackcolor(node.Nodes[i]);
                }
            }
        }

        private void SearchLayer(TreeNode node, string name)
        {
            if (node.Nodes.Count != 0)
            {
                for (int i = 0; i < node.Nodes.Count; i++)
                {
                    SearchLayer(node.Nodes[i], name);
                }
            }
            else if (string.Equals(node.Text, name) || node.Text.Contains(name))
            {
                searchTreeNodes.Add(node);
            }
        }

        private void ExpandNode(TreeNode node)
        {
            if (node.Parent != null)
            {
                node.Expand();
                ExpandNode(node.Parent);
            }
        }

        public void PostMess(IntPtr hwmd, int msg)
        {
            PostMessage(hwmd, msg, 0, 0);
        }
        #endregion

        #region Event
        private void tsmi_NewFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "flow文件|*.flow";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.AppendAllText(sfd.FileName, "");
                    string json = "";
                    try
                    {
                        TextReader reader = File.OpenText(sfd.FileName);
                        var deserializer = new DeserializerBuilder()
                            .Build();
                        var yamlObject = deserializer.Deserialize(reader);
                        var serializer = new SerializerBuilder()
                            .JsonCompatible()
                            .Build();
                        json = serializer.Serialize(yamlObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yaml文件解析失败!", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cls_Logger.Instance.WriteExceptionLog(ex);
                        return;
                    }

                    DisplayTreeView(JToken.Parse(json), "root");
                    tssl_YAMLStatus.Text = "，共侦测到" + nameCount + "个Name,侦测到" + flowCount + "个Flow";
                }
            }
        }

        private void tsmi_ReadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "flow文件|*.flow";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txt_FlowPath.Text = ofd.FileName;
                    nameCount = 0;
                    flowCount = 0;
                    string json = "";
                    try
                    {
                        TextReader reader = File.OpenText(ofd.FileName);
                        var deserializer = new DeserializerBuilder()
                            .Build();
                        var yamlObject = deserializer.Deserialize(reader);
                        var serializer = new SerializerBuilder()
                            .JsonCompatible()
                            .Build();
                        json = serializer.Serialize(yamlObject);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Yaml文件解析失败!", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cls_Logger.Instance.WriteExceptionLog(ex);
                        return;
                    }

                    DisplayTreeView(JToken.Parse(json), "root");
                    tssl_YAMLStatus.Text = "，共侦测到" + nameCount + "个Name,侦测到" + flowCount + "个Flow";
                }
            }
        }

        private void tsmi_WriteFile_Click(object sender, EventArgs e)
        {
            TreeNode tn = tv_ShowNodes.Nodes[0];
            string st = tn.Tag.ToString().Replace("\r", "").Replace("\n", "");

            var expConverter = new ExpandoObjectConverter();
            dynamic deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(st, expConverter);

            var serializer = new Serializer();
            string yaml = serializer.Serialize(deserializedObject);
            //MessageBox.Show(yaml);
            string[] logText = new string[] { yaml };
            //File.AppendAllLines(Path.GetDirectoryName(Application.StartupPath) + "\\" + "hehe.log", logText); //追加
            File.WriteAllLines(txt_FlowPath.Text, logText); //覆盖写
        }

        private void tsmi_SaveAsFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "flow文件|*.flow";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    TreeNode tn = tv_ShowNodes.Nodes[0];
                    string st = tn.Tag.ToString().Replace("\r", "").Replace("\n", "");

                    var expConverter = new ExpandoObjectConverter();
                    dynamic deserializedObject = JsonConvert.DeserializeObject<ExpandoObject>(st, expConverter);

                    var serializer = new Serializer();
                    string yaml = serializer.Serialize(deserializedObject);
                    //MessageBox.Show(yaml);
                    string[] logText = new string[] { yaml };
                    //File.AppendAllLines(Path.GetDirectoryName(Application.StartupPath) + "\\" + "hehe.log", logText); //追加
                    File.WriteAllLines(sfd.FileName, logText); //覆盖写
                }
            }
        }

        private void tsmi_NewNode_Click(object sender, EventArgs e)
        {
            if (tv_ShowNodes.SelectedNode == null)
                return;

            tv_ShowNodes.BeginUpdate();
            TreeNode selectedNode = tv_ShowNodes.SelectedNode;
            int nodeNum = selectedNode.Nodes.Add(new TreeNode("New Node"));
            selectedNode.Expand();
            tv_ShowNodes.EndUpdate();
            tv_ShowNodes.SelectedNode = selectedNode.Nodes[nodeNum];
            tv_ShowNodes.SelectedNode.BeginEdit();
        }

        private void tsmi_DeleteNode_Click(object sender, EventArgs e)
        {
            if (tv_ShowNodes.SelectedNode == null || "root".Equals(tv_ShowNodes.SelectedNode.Text))
                return;

            if (MessageBox.Show("确认要删除该节点?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            TreeNode tn = tv_ShowNodes.SelectedNode;
            tn.Remove();
        }

        private void tsmi_RenameNode_Click(object sender, EventArgs e)
        {
            if (tv_ShowNodes.SelectedNode == null || "root".Equals(tv_ShowNodes.SelectedNode.Text))
                return;

            tv_ShowNodes.SelectedNode.BeginEdit();
        }

        private void tsmi_CopyNodeName_Click(object sender, EventArgs e)
        {
            if (tv_ShowNodes.SelectedNode == null)
                return;

            Clipboard.SetDataObject(tv_ShowNodes.SelectedNode.Text);
        }

        private void tv_ShowNodes_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = tv_ShowNodes.GetNodeAt(e.X, e.Y);
                if (tn != null)
                {
                    tv_ShowNodes.SelectedNode = tn;
                }
            }
        }

        private void btn_PrevNode_Click(object sender, EventArgs e)
        {
            searchTreeNodes[currentSelectedNode].BackColor = Color.White;
            currentSelectedNode--;
            if (searchTreeNodes.Count > 0)
            {
                if (currentSelectedNode < 0)
                    currentSelectedNode = searchTreeNodes.Count - 1;
                currentSelectedNode %= searchTreeNodes.Count;
                TreeNode tn = searchTreeNodes[currentSelectedNode];
                tn.BackColor = Color.YellowGreen;
                tv_ShowNodes.SelectedNode = tn;
            }
        }

        private void btn_NextNode_Click(object sender, EventArgs e)
        {
            searchTreeNodes[currentSelectedNode].BackColor = Color.White;
            currentSelectedNode++;
            if (searchTreeNodes.Count > 0)
            {
                currentSelectedNode %= searchTreeNodes.Count;
                TreeNode tn = searchTreeNodes[currentSelectedNode];
                tn.BackColor = Color.YellowGreen;
                tv_ShowNodes.SelectedNode = tn;
            }
        }

        private void btn_LocateNode_Click(object sender, EventArgs e)
        {
            tv_ShowNodes.SelectedNode = null;
            if (searchTreeNodes.Count > 0)
            {
                tv_ShowNodes.SelectedNode = searchTreeNodes[currentSelectedNode];
            }
        }

        private void tsmi_NodeProperty_Click(object sender, EventArgs e)
        {
            // || tv_ShowNodes.SelectedNode.Tag == null --???忘了是用来防止什么事情了。
            if (tv_ShowNodes.SelectedNode == null || "root".Equals(tv_ShowNodes.SelectedNode.Text))
                return;
            this.Visible = false;
            frm_JobType jt;
            if (tv_ShowNodes.SelectedNode.Tag != null)
            {
                //说明是之前就存在属性就节点
                string parentInfo = tv_ShowNodes.SelectedNode.Parent.Tag.ToString();
                string sub = tv_ShowNodes.SelectedNode.Tag.ToString();
                jt = new frm_JobType(sub + "%" + parentInfo);
            }
            else
            {
                //说明是新建的节点
                jt = new frm_JobType(true);
            }
            jt.ShowDialog();
        }

        private void tsmi_DBConfig_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frm_DBConfig dbc = new frm_DBConfig();
            dbc.ShowDialog();
        }

        private void tsmi_DBConnect_Click(object sender, EventArgs e)
        {
            if (cls_Database.linkStatus)
            {
                try
                {
                    if (cls_Database.conn != null)
                        cls_Database.conn.Close();
                }
                catch (Exception ex)
                {
                    cls_Logger.Instance.WriteExceptionLog(ex);
                }
                finally
                {
                    cls_Database.conn.Dispose();
                    tsmi_DBConnect.Text = "连接";
                    tsmi_DBConnect.BackColor = Color.Transparent;
                    tssl_DBStatus.Text = "未连接";
                    tssl_DBStatus.BackColor = Color.Red;
                    cls_Database.linkStatus = false;
                }
            }
            else
            {
                if (cls_Database.linking || "0".Equals(dbEnable))
                    return;
                callConnectDB connectDB = new callConnectDB(ConnectDB);
                connectDB.BeginInvoke(null, null);

                /*string connStr = string.Format("datasource={0};port={1};userid={2};pwd={3}", cls_Database.hostName, cls_Database.port, cls_Database.userName, cls_Database.password);
                try
                {
                    cls_Database.conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                    cls_Database.conn.Open();
                    tsmi_DBConnect.Text = "断开连接";
                    tsmi_DBConnect.BackColor = Color.YellowGreen;
                    tssl_DBStatus.Text = "已连接";
                    tssl_DBStatus.BackColor = Color.Lime;
                    cls_Database.linkStatus = true;
                }
                catch (Exception ex)
                {
                    cls_Logger.Instance.WriteExceptionLog(ex);
                    cls_Database.linkStatus = false;
                }*/
            }
        }

        private void btn_SearchNode_Click(object sender, EventArgs e)
        {
            tv_ShowNodes.SelectedNode = null;
            foreach (TreeNode node in tv_ShowNodes.Nodes)
            {
                ResetBackcolor(node);
            }

            if (string.IsNullOrEmpty(txt_SearchNode.Text))
            {
                MessageBox.Show("请输入搜索内容!", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            searchTreeNodes = new List<TreeNode>();
            foreach (TreeNode node in tv_ShowNodes.Nodes)
            {
                SearchLayer(node, txt_SearchNode.Text);
            }

            for (int i = 0; i < searchTreeNodes.Count; i++)
            {
                TreeNode temp = searchTreeNodes[i];
                ExpandNode(temp);
                if (i == 0 && temp.Parent != null)
                {
                    temp.BackColor = Color.YellowGreen;
                    tv_ShowNodes.SelectedNode = temp;
                    currentSelectedNode = 0;
                }
            }
        }
        #endregion

        #region Message
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case cls_Msg.MAKE_MAINFRM_VISIBLE:
                    this.Visible = true;
                    break;

                case cls_Msg.CONNECT_DB_SUCCESS:
                    tsmi_DBConnect.Text = "断开连接";
                    tsmi_DBConnect.BackColor = Color.YellowGreen;
                    tssl_DBStatus.Text = "已连接";
                    tssl_DBStatus.BackColor = Color.Lime;
                    cls_Database.linking = false;
                    break;

                case cls_Msg.CONNECT_DB_FAIL:
                    MessageBox.Show("数据库连接失败!", "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cls_Database.linking = false;
                    break;

                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        #endregion

    }
}
