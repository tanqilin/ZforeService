using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZforeFromwork.ReadCard
{
    /// <summary>
    /// 绑定外部Dll
    /// </summary>
    public class Card
    {
        #region 导入外部DLL
        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static IntPtr ZKNIDReaderAPI_Open(int iPort);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_Close(IntPtr handle);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_Authenticate(IntPtr handle);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_DecodePhoto(IntPtr handle);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_ReadCard(IntPtr handle, int ctlCode);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetName(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetSex(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetNation(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetBirthdate(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetAddress(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetIDNum(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetIssue(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetEffectedDate(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetExpiredDate(IntPtr handle, byte[] data, int cbData);

        [DllImport("idcard\\NIDReaderAPI.dll")]
        public extern static int ZKNIDReaderAPI_GetBmpPhotoPath(IntPtr handle, byte[] data, int size);
        #endregion
    }
}
