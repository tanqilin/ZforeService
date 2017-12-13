using NetSDKCS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;
using ZforeFromwork.Util;

namespace ZforeServiceClient.Forms
{
    public partial class DHVideoForm : Form
    {
        #region 属性和构造函数
        private IVideoService _videoService;

        /// 调用大华网络摄像头
        IntPtr loginID = IntPtr.Zero;
        IntPtr realHandle = IntPtr.Zero;
        private const uint TimeOut = 5000;   // 连接超时

        public DHVideoForm()
        {
            InitializeComponent();
            _videoService = new VideoService();
        }

        protected override void OnLoad(EventArgs e)
        {
            List<Video> videos = _videoService.GetAllVideo();
            this.dataGridVideo.DataSource = videos;
            this.IniConfigControl();
        }

        /// <summary>
        /// 打开摄像头
        /// </summary>
        /// <param name="video"></param>
        public void InitDhVideo(Video video)
        {
            try
            {
                /// 初始化大华SDK
                bool res = NETClient.Init(null, IntPtr.Zero, null); //init NetClient.
                if (res == false)
                {
                    this.rightAdd.Enabled = false;
                }
                else
                {
                    NET_DEVICEINFO_Ex deviceInfo = new NET_DEVICEINFO_Ex();
                    loginID = NETClient.Login(video.IP, Convert.ToUInt16(video.Port), video.UserName, video.Password, EM_LOGIN_SPAC_CAP_TYPE.TCP, IntPtr.Zero, ref deviceInfo);
                    if (loginID != IntPtr.Zero)
                    {
                        realHandle = NETClient.StartRealPlay(loginID, 0, videoWin.Handle, EM_RealPlayType.Realplay, null, null, IntPtr.Zero, TimeOut);
                    }
                }
                this.rightAdd.Enabled = true;
            }
            catch
            {
                this.rightAdd.Enabled = false;
                MessageBox.Show("连接失败，请检查配置信息是否正确");
            }
        }
        #endregion

        #region 初始化配置模块控件
        private void IniConfigControl(Video video = null)
        {
            if(video != null)
            {
                this.vidoeLabe.Text = video.VideoName;
                this.videoIP.Text = video.IP;
                this.videoPort.Text = video.Port.ToString();
                this.userN.Text = video.UserName;
                this.videoPsw.Text = video.Password;
                this.videoEnable.Checked = !video.Enable;
            }
            else
            {
                this.vidoeLabe.Text = "实名制抓拍";
                this.videoIP.Text = "192.168.1.108";
                this.videoPort.Text = "37777";
                this.userN.Text = "admin";
                this.videoPsw.Text = "admin";
                this.videoEnable.Checked = false;
            }
        }
        #endregion

        #region 测试连接
        /// <summary>
        /// 测试摄像头连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void testCon_Click(object sender, EventArgs e)
        {
            Video video = new Video();
            video.VideoName = this.vidoeLabe.Text.Trim();
            video.IP = this.videoIP.Text.Trim();
            video.Port = Convert.ToInt32(this.videoPort.Text.Trim());
            video.UserName = this.userN.Text.Trim();
            video.Password = this.videoPsw.Text.Trim();
            this.InitDhVideo(video);
        }
        #endregion

        #region 保存配置信息
        /// <summary>
        /// 保存配置信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightAdd_Click(object sender, EventArgs e)
        {
            string VideoName = this.vidoeLabe.Text.Trim();
            string Password = this.videoPsw.Text.Trim();
            if (String.IsNullOrEmpty(Password) || String.IsNullOrEmpty(VideoName)) return;

            Video video = _videoService.GetVideoByName(VideoName);
            /// 是更新还是插入
            bool flag = false;
            if (video == null)
            {
                flag = true;
                video = new Video();
            }

            try
            {
                video.VideoName = VideoName;
                video.IP = this.videoIP.Text.Trim();
                video.Port = Convert.ToInt32(this.videoPort.Text.Trim());
                video.UserName = this.userN.Text.Trim();
                video.Password = Password;
                video.Enable = !(this.videoEnable.Checked);

                if (!flag)
                    _videoService.UpdateVideo(video);
                else
                    _videoService.InsertVideo(video);

                /// 重新渲染数据
                this.dataGridVideo.DataSource = _videoService.GetAllVideo();
            }
            catch(Exception err)
            {
                LogUtil.WaringLog("添加摄像头失败，所有值必须非空！"+ err.StackTrace);
            }
        }
        #endregion

        #region 关闭窗口
        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 数据表格中的双击事件
        private void dataGridVideo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Video video = (Video)this.dataGridVideo.Rows[e.RowIndex].DataBoundItem;
            if (video == null) return;
            this.InitDhVideo(video);
            this.IniConfigControl(video);
        }
        #endregion
    }
}
