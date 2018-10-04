using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemadeAbogados
{
    public partial class MenuInicio : Form
    {
        //creamos dos variables para guardar la posicion del formulario 
        //y asi poder minimizar apropiadamente
        int Lx, Ly;
        public MenuInicio()
        {
            InitializeComponent();
            //AbrirFormularioEnPanel(new FormInicio());
            //hace transparente una parte del form con ese color
            //this.TransparencyKey = Color.FromArgb(42, 58, 83);
            // this.BackColor = Color.FromArgb(42, 58, 83);
            this.Opacity = 0.95;
            AbrirFormularioEnPanel(new FormInicioSecretario());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void menuslide_Click(object sender, EventArgs e)
        {            
            if (menuvertical.Width == 250)
            {
                menuvertical.Width = 61;
            }
            else
            {
                menuvertical.Width = 250;
            }
        }

        //funcion para llamar al formulario hijo dentro del padre (que es el menu)
        private void AbrirFormularioEnPanel(object Formhijo)
        {
            if (this.PanelContenedor.Controls.Count > 0)

                this.PanelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(fh);
            this.PanelContenedor.Tag = fh;
            fh.Show();

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //en el click de este boton llamamos al formulario de estudios juridicos
            //y lo alojamos en el form padre, que es el menu
            AbrirFormularioEnPanel(new RegistrarProcuracionSecretario());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //en el click de este boton llamamos al formulario de estudios juridicos
            //y lo alojamos en el form padre, que es el menu
            AbrirFormularioEnPanel(new ConsultarProcuracion());
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

           
        }


        private void picmaximizar_Click(object sender, EventArgs e)
        {
            //guardamos la posicion para minimizar correctamente
            Lx = this.Location.X;
            Ly = this.Location.Y;
            //decimos que el tamaño del form será igual al del area de trabajo
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //y la posicion es igual a la posicion del area de trabajo
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            picminimizar.Visible = false;
            picminimizar.Visible = true;
            picmaximizar.Visible = false;
        }

        private void picminimizar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1120, 570);
            picminimizar.Visible = false;
            picmaximizar.Visible = true;
            picocultar.Visible = true;
            this.Location = new Point(Lx, Ly);
        }

        private void picocultar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            picminimizar.Visible = true;
            picmaximizar.Visible = true;
        }

        private void btnestudiosjuridicos_Click(object sender, EventArgs e)
        {
            //en el click de este boton llamamos al formulario de estudios juridicos
            //y lo alojamos en el form padre, que es el menu
           AbrirFormularioEnPanel(new FormInicioSecretario());
        }

        private void btnRegistrarMovimiento_Click(object sender, EventArgs e)
        {
            //en el click de este boton llamamos al formulario de estudios juridicos
            //y lo alojamos en el form padre, que es el menu
            AbrirFormularioEnPanel(new RegistrarMovimientoSecretario());
        }

        private void btnConsultarMovimiento_Click(object sender, EventArgs e)
        {
            //en el click de este boton llamamos al formulario de estudios juridicos
            //y lo alojamos en el form padre, que es el menu
           // AbrirFormularioEnPanel(new Consultar());
        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /*metodo que permite redimensionar la ventana tirando de ella. No se usa porque bloquea la animacion
        protected override void WndProc(ref Message msj)
        {
            const int CoordenadaWFP = 0x84; //ibicacion de la parte derecha inferior del form
            const int DesIzquierda = 16;
            const int DesDerecha = 17;
            if (msj.Msg == CoordenadaWFP)
            {
                int x = (int)(msj.LParam.ToInt64() & 0xFFFF);
                int y = (int)((msj.LParam.ToInt64() & 0xFFFF0000) >> 16);
                Point CoordenadaArea = PointToClient(new Point(x, y));
                Size TamañoAreaForm = ClientSize;
                if (CoordenadaArea.X >= TamañoAreaForm.Width - 16 && CoordenadaArea.Y >= TamañoAreaForm.Height - 16 && TamañoAreaForm.Height >= 16)
                {
                    msj.Result = (IntPtr)(IsMirrored ? DesIzquierda : DesDerecha);
                    return;
                }
            }
            base.WndProc(ref msj);
        }
        */

    }
}
