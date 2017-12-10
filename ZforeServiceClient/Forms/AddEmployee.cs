using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZforeFromwork.Database.Entity;
using ZforeFromwork.Database.Model;
using ZforeFromwork.Database.Service.Interface;
using ZforeFromwork.Database.Service.Realization;
using ZforeFromwork.ReadCard;

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

        int m_iPort = 1001;
        IntPtr m_hDevice = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;

        public AddEmployee()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            IJobService _jobService = new JobService();
            var jobs = _jobService.GetAllJobs();
            this.combo_work.DataSource = jobs;
        }
        #endregion

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


        /// <summary>
        /// 添加人员
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rightSave_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeWin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
