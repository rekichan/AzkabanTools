using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace AzkabanTools
{
    public partial class frm_DBConfig : Form
    {

        #region Properties
        private string hostName;
        private string port;
        private string userName;
        private string password;
        private string dbEnable;
        #endregion

        #region Constructor
        public frm_DBConfig()
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
        private void frm_DBConfig_Load(object sender, EventArgs e)
        {
            string path = cls_Database.dbConfigPath;
            cls_Database.config = new cls_WRIni(path);
            hostName = cls_Database.config.IniReadValue("DBConfig", "HostName", "localhost");
            port = cls_Database.config.IniReadValue("DBConfig", "Port", "3306");
            userName = cls_Database.config.IniReadValue("DBConfig", "UserName", "root");
            password = cls_Database.config.IniReadValue("DBConfig", "Password", "******");
            dbEnable = cls_Database.config.IniReadValue("DBConfig", "DBEnable", "0");

            txt_HostName.Text = hostName;
            txt_Port.Text = port;
            txt_UserName.Text = userName;
            txt_Password.Text = password;
            chk_DBEnable.Checked = dbEnable == "1" ? true : false;

            if (cls_Database.linkStatus)
            {
                btn_Connect.Text = "断开连接";
                btn_Connect.BackColor = Color.YellowGreen;
            }
            else
            {
                btn_Connect.Text = "连接";
                btn_Connect.BackColor = Color.Transparent;
            }
        }

        private void frm_DBConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            PostMess(cls_Msg.hwndFrmMain, cls_Msg.MAKE_MAINFRM_VISIBLE);
        }
        #endregion

        #region Event
        private void btn_Connect_Click(object sender, EventArgs e)
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
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cls_Database.conn.Dispose();
                    btn_Connect.Text = "连接";
                    btn_Connect.BackColor = Color.Transparent;
                    lsb_DB.Items.Clear();
                    cls_Database.linkStatus = false;
                }
            }
            else
            {
                string connStr = string.Format("datasource={0};port={1};userid={2};pwd={3}", hostName, port, userName, password);
                try
                {
                    cls_Database.conn = new MySqlConnection(connStr);
                    cls_Database.conn.Open();
                    btn_Connect.Text = "断开连接";
                    btn_Connect.BackColor = Color.YellowGreen;
                    cls_Database.linkStatus = true;
                    /*MySqlCommand cmd = new MySqlCommand("show databases", cls_Database.conn);
                    MySqlDataReader mdr = cmd.ExecuteReader();
                    while (mdr.Read())
                    {
                        string tmp = mdr.GetString("database");
                        lsb_DB.Items.Add(tmp);
                    }
                    mdr.Close();*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    cls_Database.linkStatus = false;
                }
            }
        }

        private void btn_SaveDBConfig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确认保存新的配置?", "Q", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                hostName = txt_HostName.Text;
                port = txt_Port.Text;
                userName = txt_UserName.Text;
                password = txt_Password.Text;
                cls_Database.config.IniWriteValue("DBConfig", "HostName", hostName);
                cls_Database.config.IniWriteValue("DBConfig", "Port", port);
                cls_Database.config.IniWriteValue("DBConfig", "UserName", userName);
                cls_Database.config.IniWriteValue("DBConfig", "Password", password);
                cls_Database.config.IniWriteValue("DBConfig", "DBEnable", chk_DBEnable.Checked ? "1" : "0");
            }
        }

        private void lsb_DB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lsb_DB.SelectedIndex < 0)
                return;

            /*string selectDB = lsb_DB.SelectedItem.ToString();
            cls_Database.conn.ChangeDatabase(selectDB);
            MySqlCommand cmd = new MySqlCommand("show tables", cls_Database.conn);
            MySqlDataReader mdr = cmd.ExecuteReader();
            List<string> tables = new List<string>();
            while (mdr.Read())
            {
                string tmp = mdr.GetValue(0).ToString();
                lsb_Table.Items.Add(tmp);
            }
            mdr.Close();*/
        }
        #endregion

        #region Function
        public void PostMess(IntPtr hwmd, int msg)
        {
            PostMessage(hwmd, msg, 0, 0);
        }
        #endregion

    }
}
