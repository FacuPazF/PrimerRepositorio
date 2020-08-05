using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerProyecto
{
    public partial class frmLogin : Form
    {
        string user = "admin";
        string pw = "1234";



        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (this.txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar Usuario...   ");
                this.txtUsuario.Focus();
                return;
            };
            //if (this.txtClave.Text == "")
            if (string.IsNullOrEmpty(this.txtClave.Text))
            {
                MessageBox.Show("Debe Ingresar Clave...");
                this.txtClave.Focus();
                return;
            }

            // Validar Nombre de Usuario y Clave
            string msg = "";

            /*if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pw)
                msg = "Login Ok";
            else
                msg = "Usuario y/o clave incorrectos";
            */
            if (this.txtUsuario.Text == this.user && this.txtClave.Text == this.pw)
            {
                msg = "Login Ok";
                MessageBox.Show(msg, "Ingreso al Sistema ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            else
            {
                msg = "Usuario y/o clave incorrectos";
                MessageBox.Show(msg, "Ingreso al Sistema ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = string.Empty;
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            };
                
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
