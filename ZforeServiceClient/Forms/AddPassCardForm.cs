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

namespace ZforeServiceClient.Forms
{
    public partial class AddPassCardForm : Form
    {
        #region 属性和构造函数
        private Employee employee = null;
        private IEmployeeService _employeeService = null;

        public AddPassCardForm(Employee employee)
        {
            InitializeComponent();
            this.employee = employee;
            _employeeService = new EmployeeService();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.name.Text = employee.EmployeeName;
            this.cardNum.Text = employee.CardNo;
        }
        #endregion

        #region 发 卡
        /// <summary>
        /// 发卡
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitCard_Click(object sender, EventArgs e)
        {
            string cardNum = this.cardNum.Text.Trim();
            string cardPin = this.password.Text.Trim();
            string endTime = this.endDateTime.Text.Trim();

            List<Employee> data = _employeeService.FindEmployee(cardNum);
            if (employee.CardNo != cardNum && (data != null && data.Count > 0))
            {
                MessageBox.Show("该卡已经被使用了！", "错误！", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.employee.CardNo = cardNum;
                this.employee.pin = cardPin;
                this.employee.EndDate = DateTime.Parse(endTime);
                _employeeService.UpdateEmployee(this.employee);
                this.DialogResult = DialogResult.OK;
            }
        }
        #endregion

        #region 关闭窗口
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
