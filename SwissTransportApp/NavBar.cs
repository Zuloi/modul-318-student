using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp
{
    public partial class NavBar : Form
    {
        public NavBar()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        private void SwissTransport_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void ExitForms_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void MinimizedForms_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        

        private void MaximizedForms_Click(object sender, EventArgs e)
        {
            

            if (WindowState == FormWindowState.Normal) {
               WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }




        private void StationBoard_Click(object sender, EventArgs e)
        {
            StationBoard stationboard = new StationBoard();
            nav(stationboard, content);
        }

        private void ConnectionSearch_Click(object sender, EventArgs e)
        {
            ConnectionSearch connectionsearch = new ConnectionSearch();
            nav(connectionsearch, content);
        }
       

        public void nav(Form form, Panel panel)
        {
            form.TopLevel = false;
            form.Size = panel.Size; // for responsive size
            panel.Controls.Clear();
            panel.Controls.Add(form);
            form.Show();
        }

      
    }
}
