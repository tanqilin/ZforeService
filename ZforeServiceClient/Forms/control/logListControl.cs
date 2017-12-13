using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace ZforeServiceClient.Forms.control
{
    public class logListControl
    {
        public IntPtr List_Handle = IntPtr.Zero;

        public logListControl(IntPtr Handle)
        {
            this.List_Handle = Handle;
        }
    }
}
