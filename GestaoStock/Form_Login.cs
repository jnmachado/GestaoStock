using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoStock
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            this.MinimizeBox = false; //Retirar o Botão de Minimizar
            this.MaximizeBox = false; //Retirar o Botão de Maximizar

        }

        private void btn_login_Click(object sender, EventArgs e)//Permite fazer login carregando no BUTTON
        {
            login();
           
        }

        private void txt_user_KeyDown(object sender, KeyEventArgs e)//Permite fazer login carregando no ENTER
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }

        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e) //Permite fazer login carregando no ENTER
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            
            }
        }

        private void login() //Envia o User e a Pass para a BLL
        {
            BLL b = new BLL();

            if (b.validaLogin(txt_user.Text, txt_pass.Text))
            {
                this.Hide();
            }
            else
            {
                this.txt_user.Text = "";
                this.txt_pass.Text = "";
            }
        }
    }
}
