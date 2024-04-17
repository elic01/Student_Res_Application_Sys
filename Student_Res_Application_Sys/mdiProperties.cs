using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Student_Res_Application_Sys
{
    public static class mdiProperties
    {
        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [DllImport("user32.dll")]
        private static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        
        private const int GWL_EXSTYLE = -16;
        private const int WS_EX_CLIENTEDGE = 0x200;
        private const int SWP_NOSIZE = 0x0001;
        private const int SWP_NOMOVE = 0x0002;
        private const int SWP_NOZORDER = 0x0004;
        private const int SWP_NOACTIVATE = 0x0010;
        private const int SWP_FRAMECHANGED = 0x0020;
        private const int SWP_NOOWNERZORDER = 0x0200;
         
        public static bool SetBevel(this Form form,bool show)
        {
            foreach (Control control in form.Controls)
            {
                MdiClient mdiClient = control as MdiClient;
                if (mdiClient != null)
                {
                    int windowLong = GetWindowLong(mdiClient.Handle, GWL_EXSTYLE);
                    if (show)
                    {
                        windowLong |= WS_EX_CLIENTEDGE;
                    }
                    else
                    {
                        windowLong &= WS_EX_CLIENTEDGE;
                    }
                    SetWindowLong(mdiClient.Handle, GWL_EXSTYLE, windowLong);
                    SetWindowPos(mdiClient.Handle, IntPtr.Zero, 0, 0, 0, 0, SWP_NOSIZE | SWP_NOMOVE | SWP_NOZORDER | SWP_NOACTIVATE | SWP_FRAMECHANGED | SWP_NOOWNERZORDER);
                    return true;
                }
            }
            return false;
        }
    
    }
}
