using System;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Collections.Generic;

namespace AzkabanTools
{
    public partial class frm_JobType : Form
    {

        #region Properties
        private string content;
        private List<string> cbxItems = new List<string>();
        private bool isCbxLeave;
        private bool isCbxEnter;
        private DataGridViewCell dgvC;
        private bool newNode;
        #endregion

        #region Constructor
        public frm_JobType()
        {
            InitializeComponent();
        }

        public frm_JobType(bool isNew)
        {
            InitializeComponent();
            this.newNode = isNew;
        }

        public frm_JobType(string content)
        {
            InitializeComponent();
            this.content = content;
        }
        #endregion

        #region API
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.dll ", CharSet = CharSet.Unicode)]
        public static extern IntPtr PostMessage(IntPtr hwnd, int wMsg, IntPtr wParam, int lParam);
        #endregion

        #region FormEvent
        private void frm_JobType_Load(object sender, EventArgs e)
        {
            if (newNode)
            {

            }
            else
            {
                string[] info = content.Split('%');

                /*----------------super------------------*/
                JToken superToken = JToken.Parse(info[1]);
                string superName = superToken.Value<string>("name");
                string superType = superToken.Value<string>("type");
                DataGridViewRow superBufferRow = new DataGridViewRow();
                DataGridViewTextBoxCell superCell = new DataGridViewTextBoxCell();
                superCell.Value = "Super Node";
                superBufferRow.Cells.Add(superCell);
                superBufferRow.DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                dgv_JobInfo.Rows.Add(superBufferRow);
                superBufferRow.ReadOnly = true;

                DataGridViewRow superNameRow = new DataGridViewRow();
                DataGridViewTextBoxCell superNameKeyCell = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell superNameValueCell = new DataGridViewTextBoxCell();
                superNameKeyCell.Value = "name";
                superNameValueCell.Value = superName != null ? superName : "null";
                superNameRow.Cells.Add(superNameKeyCell);
                superNameRow.Cells.Add(superNameValueCell);
                dgv_JobInfo.Rows.Add(superNameRow);
                superNameRow.ReadOnly = true;

                DataGridViewRow superTypeRow = new DataGridViewRow();
                DataGridViewTextBoxCell superTypeKeyCell = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell superTypeValueCell = new DataGridViewTextBoxCell();
                superTypeKeyCell.Value = "type";
                superTypeValueCell.Value = superType != null ? superType : "null";
                superTypeRow.Cells.Add(superTypeKeyCell);
                superTypeRow.Cells.Add(superTypeValueCell);
                dgv_JobInfo.Rows.Add(superTypeRow);
                superTypeRow.ReadOnly = true;

                /*----------------sub------------------*/
                JToken subToken = JToken.Parse(info[0]);
                string subType = subToken.Value<string>("type");
                string subName = subToken.Value<string>("name");
                if (subToken is JObject)
                {
                    DataGridViewRow subBufferRow = new DataGridViewRow();
                    DataGridViewTextBoxCell subCell = new DataGridViewTextBoxCell();
                    subCell.Value = "Sub Node";
                    subBufferRow.Cells.Add(subCell);
                    subBufferRow.DefaultCellStyle.BackColor = System.Drawing.Color.YellowGreen;
                    dgv_JobInfo.Rows.Add(subBufferRow);
                    subBufferRow.ReadOnly = true;

                    JObject obj = (JObject)subToken;
                    foreach (JProperty property in obj.Properties())
                    {
                        DataGridViewRow subRow = new DataGridViewRow();
                        DataGridViewTextBoxCell subKeyCell = new DataGridViewTextBoxCell();
                        DataGridViewTextBoxCell subValueCell = new DataGridViewTextBoxCell();
                        subKeyCell.Value = property.Name;
                        subValueCell.Value = property.Value;
                        subRow.Cells.Add(subKeyCell);
                        subRow.Cells.Add(subValueCell);
                        dgv_JobInfo.Rows.Add(subRow);

                        cbxItems.Add(property.Name); //测试
                    }
                }

                JObject config = subToken.Value<JObject>("config");
                JArray ja = subToken.Value<JArray>("dependsOn");
                if (config != null && !"flow".Equals(subType))
                    txt_Config.Text = config.ToString();
                if (ja != null)
                    for (int i = 0; i < ja.Count; i++)
                        lsb_Dependency.Items.Add(ja[i]);

                showJobStatus(superName, subType, subName);
            }
        }

        private void frm_JobType_FormClosing(object sender, FormClosingEventArgs e)
        {
            PostMess(cls_Msg.hwndFrmMain, cls_Msg.MAKE_MAINFRM_VISIBLE);
        }
        #endregion

        #region Function
        public void PostMess(IntPtr hwmd, int msg)
        {
            PostMessage(hwmd, msg, 0, 0);
        }

        private void showJobStatus(string superN,string subT,string subN)
        {
            /*----------------show database info------------------*/
            if (cls_Database.linkStatus)
            {
                tssl_DBStatus.BackColor = System.Drawing.Color.Lime;
                tssl_DBStatus.Text = "已连接";
                if (!"flow".Equals(subT))
                {
                    string sql;
                    if (superN == null)
                    {
                        sql = string.Format("select flow_id, job_id, status, start_time, end_time from azkaban.execution_jobs where job_id in ('{0}') order by version desc, start_time desc limit 1", subN);
                    }
                    else
                    {
                        sql = string.Format("select flow_id, job_id, status, start_time, end_time from azkaban.execution_jobs where flow_id like '%{0}%' and job_id in ('{1}') order by version desc, start_time desc limit 1", superN, subN);
                    }
                    cls_Database.conn.ChangeDatabase("azkaban");
                    MySqlCommand cmd = new MySqlCommand(sql, cls_Database.conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();

                    //string flow_id;
                    string job_id = "";
                    short status = -1;
                    long start_time = -1;
                    long end_time = -1;
                    while (mdr.Read())
                    {
                        //flow_id = mdr.GetString("flow_id");
                        job_id = mdr.GetString("job_id");
                        status = mdr.GetInt16("status");
                        start_time = mdr.GetInt64("start_time");
                        end_time = mdr.GetInt64("end_time");
                    }
                    lbl_JobID.Text = job_id;
                    if (end_time == -1)
                        lbl_JobDuration.Text = "-1s";
                    else
                        lbl_JobDuration.Text = ((end_time - start_time) / 1000).ToString() + "s";
                    switch (status)
                    {
                        case 30:
                            pb_JobStatus.Image = Properties.Resources.blue;
                            lbl_JobStatus.Text = "running";
                            break;

                        case 50:
                            pb_JobStatus.Image = Properties.Resources.green;
                            lbl_JobStatus.Text = "success";
                            break;

                        case 60:
                            pb_JobStatus.Image = Properties.Resources.yellow;
                            lbl_JobStatus.Text = "killed";
                            break;

                        case 70:
                            pb_JobStatus.Image = Properties.Resources.red;
                            lbl_JobStatus.Text = "failed";
                            break;

                        case -1:
                            //???不能贯穿?
                            pb_JobStatus.Image = Properties.Resources.gray;
                            lbl_JobStatus.Text = "?";
                            break;

                        default:
                            pb_JobStatus.Image = Properties.Resources.gray;
                            lbl_JobStatus.Text = "?";
                            break;
                    }
                    mdr.Close();
                    mdr.Dispose();
                    cmd.Dispose();
                }
                else
                {
                    lbl_JobID.Text = "this node is flow";
                    lbl_JobStatus.Text = "null";
                    lbl_JobDuration.Text = "-1";
                }
            }
            else
            {
                tssl_DBStatus.BackColor = System.Drawing.Color.Red;
                tssl_DBStatus.Text = "未连接";
            }
        }
        #endregion

        #region Event
        private void tsmi_AddProperty_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell dgvCbx = new DataGridViewComboBoxCell();
            dgvCbx.Items.AddRange(cbxItems.ToArray());
            DataGridViewRow dgvR = new DataGridViewRow();
            dgvR.Cells.Add(dgvCbx);
            dgvR.Cells.Add(new DataGridViewTextBoxCell());
            dgv_JobInfo.Rows.Add(dgvR);
        }

        private void tsmi_DeleteProperty_Click(object sender, EventArgs e)
        {

        }

        private void dgv_JobInfo_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            dgvC = dgv.CurrentCell;
            if ("DataGridViewComboBoxCell".Equals(dgv.CurrentCell.GetType().Name) && dgv.CurrentCell.RowIndex != -1)
            {
                isCbxLeave = false;
                isCbxEnter = true;
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedChanged);
            }
        }

        private void ComboBox_SelectedChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            if (isCbxEnter)
            {
                cbx.Leave += new EventHandler(ComboBox_Leave);
                isCbxEnter = false;
            }
            try
            {
                if (cbx.SelectedItem != null)
                {
                    //test
                    int row = dgvC.RowIndex;
                    dgv_JobInfo.Rows[row].Cells[1].Value = cbx.SelectedItem.ToString();
                }
                System.Threading.Thread.Sleep(5);
            }
            catch (Exception ex)
            {
                cls_Logger.Instance.WriteExceptionLog(ex);
            }
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            if (isCbxLeave)
                return;
            isCbxLeave = true;
            ComboBox cbx = sender as ComboBox;
            cbx.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedChanged);
            dgv_JobInfo.EndEdit();
        }
        #endregion
    }
}
