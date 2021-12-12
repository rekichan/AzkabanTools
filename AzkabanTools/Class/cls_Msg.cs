using System;

namespace AzkabanTools
{
    class cls_Msg
    {
        public static IntPtr hwndFrmMain;

        public const int USER = 0x400;
        public const int MAKE_MAINFRM_VISIBLE = USER + 1; //子窗口关闭时使主窗口显示
        public const int CONNECT_DB_SUCCESS = MAKE_MAINFRM_VISIBLE + 1;
        public const int CONNECT_DB_FAIL = CONNECT_DB_SUCCESS + 1;
    }
}
