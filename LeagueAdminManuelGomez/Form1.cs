using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueAdminManuelGomez
{
    public partial class SlashScreen : Form
    {
        public SlashScreen()
        {
            InitializeComponent();
            panel.Width = 750/10;
            panel.BackColor = Color.FromArgb(44, 51, 51);
        }

        private void SlashScreen_Load(object sender, EventArgs e)
        {
            //Comienza el TImer
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //La barra avanza al avanzar el Timer
            panel.Width += 5;
            if(panel.Width == 750)
            {
                //Abrimos el formulario principal y cierro este
                timer.Stop();
                this.Hide();
                Inicio pantallaInicio = new Inicio();
                pantallaInicio.ShowDialog();
                this.Close();
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
