﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
//instanciamos la capa de dominio
using CapaDominio;
namespace SistemadeAbogados
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void tbcontraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void piccerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro que desea salir?", "¡Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void picocultar_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Minimized;
        }

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tbusuario_Enter(object sender, EventArgs e)
        {
            if (tbusuario.Text == "Usuario")
            {
                tbusuario.Text = "";
                tbusuario.ForeColor = Color.LightGray;
            }
        }

        private void tbusuario_Leave(object sender, EventArgs e)
        {
            if (tbusuario.Text == "")
            {
                tbusuario.Text = "Usuario";
                tbusuario.ForeColor = Color.DimGray;
            }
        }

        private void tbcontraseña_Enter(object sender, EventArgs e)
        {

            if (tbcontraseña.Text == "Contraseña")
            {
                tbcontraseña.Text = "";
                tbcontraseña.ForeColor = Color.LightGray;
                tbcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void tbcontraseña_Leave(object sender, EventArgs e)
        {

            if (tbcontraseña.Text == "")
            {
                tbcontraseña.Text = "Contraseña";
                tbcontraseña.ForeColor = Color.DimGray;
                tbcontraseña.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            
            //usuario y contraseña no vacios
            if (tbusuario.Text != "Usuario")
            {
                if (tbcontraseña.Text != "Contraseña")
                {
                    pberroringreso.Visible = false;
                    lblerror.Visible = false;
                    //en caso de que este correcto
                    //instanciamos al modelo usuario de la capa de dominio
                    ModeloDominioUsuario usuario = new ModeloDominioUsuario();
                    //declaramos una variable implicita y asignamos como valor el resultado
                    var loginvalido = usuario.LoginUser(tbusuario.Text, tbusuario.Text);
                    if (loginvalido == true)
                    {
                        //mostramos el formulario principal y 
                        Form MenuInicio = new MenuInicio();
                        MenuInicio.Show();
                        this.Hide();
                    }
                    //pasamos de un formulario al otro
                   
                }
                else
                {
                    lblerror.Visible = true;
                    pberroringreso.Visible = true;
                    lblerror.Text = "    Ingrese contraseña";

                }
            }
            else
            {
                pberroringreso.Visible = true;
                lblerror.Visible = true;
                lblerror.Text = "    Ingrese Usuario";
            }
        }

        //metodo para mostrar el error en el logueo
        private void msgError(string msg)
        {
            lblerror.Text = "    " + msg;
            lblerror.Visible = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
