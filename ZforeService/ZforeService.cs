using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using ZforeFromwork.SqlService;
using ZforeFromwork.Util;

namespace ZforeService
{
    public partial class ZforeService : ServiceBase
    {

        #region 属性和构造函数

        string filePath = @"D:\MyServiceLog.txt";

        public ZforeService()
        {
            InitializeComponent();
        }

        #endregion

        protected override void OnStart(string[] args)
        {
            // 开启一条线程发送网络请求
            HttpRequestUtil.HttpRequest();
        }

        protected override void OnContinue()
        {
            base.OnContinue();
            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now},服务运行中！");
            }
        }

        protected override void OnStop()
        {       

            using (FileStream stream = new FileStream(filePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                writer.WriteLine($"{DateTime.Now},服务停止！");
            }
        }
    }
}
