using NetSDKCS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;
using ZforeFromwork.ReadCard;
using ZforeFromwork.Util;

namespace ZforeServiceClient.Forms
{
    /// <summary>
    /// 编辑/添加人员信息
    /// </summary>
    public partial class AddEmployee : Form
    {
        #region 属性和构造函数
        /// <summary>
        /// 读取信息存储容器
        /// </summary>
        private CardInfo card = new CardInfo();
        private Project project = null;
        private Employee editEmployee = null;
        private IJobService _jobService;
        private IVideoService _videoService;
        private IDeptAService _deptAService;
        private IEmployeeService _employeeService;

        /// 调用身份证阅读器
        int m_iPort = 1001;
        IntPtr m_hDevice = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;

        /// 调用大华网络摄像头
        IntPtr dh_loginID = IntPtr.Zero;
        IntPtr dh_handle = IntPtr.Zero;
        private byte[] dh_data = null; /// 抓拍的二进制图片
        private bool dh_initResult = false;
        private const uint TimeOut = 3000;   // 连接超时
        private uint m_SnapSerialNum = 1000;
        private fSnapRevCallBack VideoPictureCallBack;

        public AddEmployee(Project project,Employee employee = null)
        {
            InitializeComponent();
            this.project = project;
            this.editEmployee = employee;
            _jobService = new JobService();
            _videoService = new VideoService();
            _deptAService = new DeptAService();
            _employeeService = new EmployeeService();
        }

        /// <summary>
        /// 加载时初始化窗口数据
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            this.InitAllDownList();
            this.InitEmployeeControl(true);
            this.VideoPictureCallBack = new fSnapRevCallBack(GetVideoPicture);
           
            /// 初始化大华SDK
            dh_initResult = NETClient.Init(null, IntPtr.Zero, null); //init NetClient.
        }
        #endregion

        #region 初始化大华摄像头
        /// <summary>
        /// 初始化大华摄像头
        /// </summary>
        private void InitDhVideo(Video video)
        {
            try
            {
                if (dh_initResult == false)
                {
                    this.dhVideo.Enabled = false;
                }
                else
                {
                    if (dh_loginID != IntPtr.Zero) NETClient.Logout(dh_loginID);

                    NET_DEVICEINFO_Ex deviceInfo = new NET_DEVICEINFO_Ex();
                    dh_loginID = NETClient.Login(video.IP, Convert.ToUInt16(video.Port), video.UserName, video.Password, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref deviceInfo);
                    if (dh_loginID != IntPtr.Zero)
                    {
                        this.dhVideo.Enabled = true;
                        dh_handle = NETClient.StartRealPlay(dh_loginID, 0, pictureDh.Handle, EM_RealPlayType.Realplay, null, null, IntPtr.Zero, TimeOut);
                        // 设置抓拍（回调函数，抓图模式(-1停止，0一张，1定时，2停止)）
                        NETClient.SetSnapRevCallBack(VideoPictureCallBack, IntPtr.Zero);
                        this.pictureTab.SelectTab(0);
                    }
                }
            }
            catch (Exception err)
            {
                LogUtil.WaringLog("摄像头打开失败(读取人员信息窗口)：请在摄像头管理中检查该摄像头的配置"+ err.Message);
            }
        }
        #endregion

        #region 初始化所有下拉框
        private void InitAllDownList()
        {
            var depts = _deptAService.GetAllGroup();
            this.combo_group.DataSource = depts;
            var jobs = _jobService.GetAllJobs();
            this.combo_work.DataSource = jobs;
            var video = _videoService.GetAllVideo();
            this.videoList.DataSource = video;
        }
        #endregion

        #region 初始化人员信息模块控件
        private void InitEmployeeControl(bool enable = false)
        {
            this.text_name.Enabled = enable;
            this.text_sex.Enabled = enable;
            this.text_birthdate.Enabled = enable;
            this.text_number.Enabled = enable;
            this.text_address.Enabled = enable;
            this.text_nation.Enabled = enable;

            /// 不为null表示编辑时已经传了人员信息过来
            if (this.editEmployee != null)
            {
                this.text_name.Text = editEmployee.EmployeeName;
                this.text_sex.Text = editEmployee.Sex == false ? "男" : "女";
                this.text_birthdate.Text = editEmployee.Birthday.ToString("yyyy/MM/dd");
                this.text_number.Text = editEmployee.PersonCode;
                this.text_address.Text = editEmployee.Home;
                this.text_nation.Text = editEmployee.Note4;
                if (this.editEmployee.Photo != null)
                {
                    MemoryStream ms = new MemoryStream(); //新建内存流
                    ms.Write(editEmployee.Photo, 0, editEmployee.Photo.Length); // 图片
                    this.picture_image.Image = Image.FromStream(ms);
                    ms.Close();
                }
                /// 是否存在抓拍图片
                if (editEmployee.Dahua != null)
                {
                    MemoryStream dh = new MemoryStream();
                    dh.Write(editEmployee.Dahua, 0, editEmployee.Dahua.Length); // 抓拍
                    this.pictureGet.Image = Image.FromStream(dh);
                    dh.Close();
                    this.pictureTab.SelectTab(1);
                }
                /// 设置下拉框默认选中项
                this.combo_group.SelectedValue = editEmployee.DeptID;
                this.combo_work.SelectedValue = editEmployee.JobID.ToString();
            }
        }
        #endregion

        #region 身份证阅读器部分
        #region 通道1001读取及数据处理
        public void GetCardInfo()
        {
            //显示身份证信息
            text_name.Text = System.Text.Encoding.Default.GetString(card.Name);
            text_sex.Text = System.Text.Encoding.Default.GetString(card.Sex);
            text_nation.Text = System.Text.Encoding.Default.GetString(card.Nation);
            text_birthdate.Text = System.Text.Encoding.Default.GetString(card.BirthDate);
            text_number.Text = System.Text.Encoding.Default.GetString(card.CardID);
            text_address.Text = System.Text.Encoding.Default.GetString(card.Address);
        }

        /// <summary>
        /// 显示读取到的身份证头像
        /// </summary>
        public void ShowImage()
        {
            Console.WriteLine("显示图像...");

            byte[] bImgPath = new byte[512];
            int bImgPathSize = 512;
            Card.ZKNIDReaderAPI_GetBmpPhotoPath(m_hDevice, bImgPath, bImgPathSize);
            string strPath = System.Text.Encoding.Default.GetString(bImgPath);
            strPath = strPath.Replace("\0", "");
            FileStream fs = new FileStream(strPath, FileMode.Open, FileAccess.Read);
            picture_image.Image = System.Drawing.Image.FromStream(fs);
            fs.Close();
        }
        #endregion

        #region 读取二代身份证
        /// <summary>
        /// 读取二代身份证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void readCard_Click(object sender, EventArgs e)
        {
            if (IntPtr.Zero == m_hDevice)
            {
                m_hDevice = Card.ZKNIDReaderAPI_Open(m_iPort);
            }

            if (m_hDevice != IntPtr.Zero)
            {
                try
                {
                    int nRet = 1;
                    if (1 == Card.ZKNIDReaderAPI_Authenticate(m_hDevice) && 1 == Card.ZKNIDReaderAPI_ReadCard(m_hDevice, 2))
                    {
                        Console.WriteLine("开始读卡...");
                        /// 需要加入license.dat文件，否则读取头像时会报错
                        Card.ZKNIDReaderAPI_DecodePhoto(m_hDevice);
                        Card.ZKNIDReaderAPI_GetName(m_hDevice, card.Name, 128);
                        Card.ZKNIDReaderAPI_GetSex(m_hDevice, card.Sex, 128);
                        Card.ZKNIDReaderAPI_GetNation(m_hDevice, card.Nation, 128);
                        Card.ZKNIDReaderAPI_GetBirthdate(m_hDevice, card.BirthDate, 128);
                        Card.ZKNIDReaderAPI_GetIDNum(m_hDevice, card.CardID, 128);
                        nRet = Card.ZKNIDReaderAPI_GetAddress(m_hDevice, card.Address, 128);
                    }
                    if (1 == nRet)
                    {
                        ShowImage();
                        GetCardInfo();
                    }
                }
                catch { }
            }
            else
            {
                MessageBox.Show("设备连接失败");
            }
        }
        #endregion
        #endregion

        #region 摄像头部分
        /// <summary>
        /// 连接摄像头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void videoConne_Click(object sender, EventArgs e)
        {
            if (this.videoList.SelectedValue == null) return;

            string videoId = this.videoList.SelectedValue.ToString();
            Video video = _videoService.GetVideoByID(Convert.ToInt32(videoId));

            if (video == null) return;
            this.InitDhVideo(video);
        }

        /// <summary>
        /// 摄像头抓拍
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dhVideo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dh_loginID != IntPtr.Zero)
                {
                    NET_SNAP_PARAMS snap = new NET_SNAP_PARAMS();
                    snap.Channel = (uint)0; // 通道，和开启摄像头时候设置的通道必须一致
                    snap.Quality = 6;
                    snap.ImageSize = 2;
                    snap.mode = 0;
                    snap.InterSnap = 0;
                    snap.CmdSerial = m_SnapSerialNum;
                    bool ret = NETClient.SnapPictureEx(dh_loginID, snap, IntPtr.Zero);
                    if (ret)
                    {
                        this.pictureTab.SelectTab(1);
                    }
                }
            }
            catch(Exception err)
            {
                LogUtil.WaringLog("抓拍失败：" + err.Message);
            }
        }

        /// <summary>
        /// 摄像头抓拍回调函数
        /// </summary>
        /// <param name="lLoginID"></param>
        /// <param name="pBuf"></param>
        /// <param name="RevLen"></param>
        /// <param name="EncodeType"></param>
        /// <param name="CmdSerial"></param>
        /// <param name="dwUser"></param>
        public void GetVideoPicture(IntPtr lLoginID, IntPtr pBuf, uint RevLen, uint EncodeType, uint CmdSerial, IntPtr dwUser)
        {
            try
            {
                dh_data = new byte[RevLen];
                Marshal.Copy(pBuf, dh_data, 0, (int)RevLen);

                MemoryStream ms = new MemoryStream(); //新建内存流
                ms.Write(dh_data, 0, dh_data.Length); //附值

                this.pictureGet.Image = Image.FromStream(ms); //读取流中内容
            }
            catch { }
        }

        private byte[] GetImageBytes(Image image)
        {
            MemoryStream mstream = new MemoryStream();
            image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] byteData = new Byte[mstream.Length];
            mstream.Position = 0;
            mstream.Read(byteData, 0, byteData.Length);
            mstream.Close();

            return byteData;
        }
        #endregion

        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightSave_Click(object sender, EventArgs e)
        {
            string CardID = this.text_number.Text;
            if (project == null || String.IsNullOrEmpty(CardID)) return;

            if (this.pictureGet.Image == null)
            {
                MessageBox.Show("必须抓拍人员图片!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            /// 编辑人员信息
            if (editEmployee != null)
            {
                editEmployee.EmployeeName = this.text_name.Text.Trim();
                editEmployee.Car = null;
                editEmployee.EmployeeProNum = project.ProjectNum;
                editEmployee.Dahua = dh_data == null? editEmployee.Dahua : GetImageBytes(this.pictureGet.Image);
                editEmployee.DeptID = Convert.ToInt32(this.combo_group.SelectedValue);
                editEmployee.JobID = Convert.ToInt32(this.combo_work.SelectedValue);
                _employeeService.UpdateEmployee(editEmployee);
            }
            else
            {
                editEmployee = new Employee();
                editEmployee.EmployeeName = this.text_name.Text.Trim();
                editEmployee.Sex = this.text_sex.Text.Trim() == "男" ? false : true;
                editEmployee.Birthday = DateTime.Parse(this.text_birthdate.Text.Trim());
                editEmployee.PersonCode = "ID"+CardID;
                editEmployee.Home = this.text_address.Text.Trim();
                editEmployee.Note4 = this.text_nation.Text.Trim();
                editEmployee.Photo = this.picture_image.Image == null ? null: GetImageBytes(this.picture_image.Image);
                editEmployee.Dahua = GetImageBytes(this.pictureGet.Image);
                editEmployee.EmployeeProNum = project.ProjectNum;
                editEmployee.Note1 = this.text_note.Text.Trim();
                editEmployee.DeptID = Convert.ToInt32(this.combo_group.SelectedValue);
                editEmployee.JobID = Convert.ToInt32(this.combo_work.SelectedValue);
                editEmployee.Deleted = false;

                if (_employeeService.ProjectEmployeeExists(editEmployee))
                {
                    MessageBox.Show("项目下人员已存在，请勿重复添加！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    _employeeService.InsertEmployee(editEmployee);
                }
            }

            this.Close();
        }

        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeWin_Click(object sender, EventArgs e)
        {
            /// 关闭窗口前清理大华SDK
            NETClient.Cleanup();
            this.Close();
        }
    }
}
