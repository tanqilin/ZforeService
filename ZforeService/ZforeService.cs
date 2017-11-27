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

        public ZforeService()
        {
            InitializeComponent();
        }

        #endregion

        protected override void OnStart(string[] args)
        {
            /// 服务启动时清空日志文件
            LogUtil.ClearLog("ServiceLog");
            LogUtil.MsgLog("服务启动！");
            // 开启线程发送网络请求
            ThreadUtil.HttpSendHuman();
            ThreadUtil.HttpSendAttend();
            ThreadUtil.ThreadManage();
        }

        protected override void OnContinue()
        {
            base.OnContinue();
            LogUtil.MsgLog("服务运行中！");
        }

        protected override void OnStop()
        {
            LogUtil.ErrorLog("服务停止！");
        }
    }
}
