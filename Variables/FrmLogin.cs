using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class FrmLogin : Form
    {
        int contador = 0;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            tbUser.Focus();
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {
            tbPassword.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Login(tbUser.Text, tbPassword.Text))
             {
                this.DialogResult = DialogResult.OK;
                this.Close();
                



                

            }
            else
            {
                contador++;
                MessageBox.Show("Contraseña Invalida");
            }
            if (contador ==3)
            {
                MessageBox.Show("Usted ha excecido los intentos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private Boolean Login(string username, string password)
        {
            return username.Equals("admin") && password.Equals("admin");
        }
    }
}
