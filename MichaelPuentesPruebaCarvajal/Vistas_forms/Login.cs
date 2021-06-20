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
using MichaelPuentesPruebaCarvajal.Controles;
using MichaelPuentesPruebaCarvajal.Modelos;

namespace MichaelPuentesPruebaCarvajal.Vistas_forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (VerificaCasillas())
            {
                if (!cs_login.VerificarLogin(TB_username.Text, TB_password.Text))
                {
                    MessageBox.Show("Usuario No Registrado", "Ups!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    CleanTB();
                }
                else
                {

                    Principal PaginaVuelos = new Principal();
                    PaginaVuelos.Show();
                    this.Hide();
                }
            }
        }
        private void CleanTB()
        {
            TB_password.Clear();
            TB_username.Clear();
        }

        private void Btn_Registrarse_Click(object sender, EventArgs e)
        {
            if (VerificaCasillas())
            {
                if (cs_login.crearUsuario(TB_username.Text, TB_password.Text))
                {
                    Principal PaginaVuelos = new Principal();
                    PaginaVuelos.Show();
                    this.Hide();
                }
            }
            //MessageBox.Show("Por el momento ingresa con:\nusername: Mike\npassword: 1234");
        }
        private bool VerificaCasillas()
        {
            bool flag = true;
            if (TB_username.Text == null || TB_username.Text == "")
            { LB_vacio_usr.Visible = true; flag = false; }
            if (TB_password.Text == null || TB_password.Text == "")
            { LB_vacio_pass.Visible = true; flag = false; }
            return flag;
        }

        private void TB_username_TextChanged(object sender, EventArgs e)
        {
            LB_vacio_usr.Visible = false;
        }

        private void TB_password_TextChanged(object sender, EventArgs e)
        {
            LB_vacio_pass.Visible = false;
        }


    }
}
