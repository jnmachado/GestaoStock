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
    public partial class Form_Adicionar_User : Form
    {
        public Form_Adicionar_User()
        {
            InitializeComponent();
            
        }      

        private void btn_addcancelar_Click(object sender, EventArgs e)//Sai do Form
        {
            this.Close();
        }

        private void btn_addlimpar_Click(object sender, EventArgs e)//Limpas as TextBoxes
        {
            this.txt_nome.Clear();
            this.txt_email.Clear();
            this.txt_tel.Clear();
            this.txt_adduser.Clear();
            this.txt_addpass.Clear();
            this.txt_readdpass.Clear();
            this.ckb_admin.Checked = false;
        }

        private void btn_add_Click(object sender, EventArgs e)//Envia a info das textboxes para o BLL
        {
            BLL bll = new BLL();
            int priv;
            if (ckb_admin.Checked)
            {
                priv = 1;
            }
            else
            {
                priv = 0;
            }
            int opt = bll.addUser(txt_nome.Text, txt_email.Text, txt_tel.Text, txt_adduser.Text, txt_addpass.Text, txt_readdpass.Text, priv);
            if (opt == 0)
            {
                txt_addpass.Text = "";
                txt_readdpass.Text = "";

            }else if(opt == 1)
            {
                txt_nome.Text = "";

            }
            else if (opt == 2)
            {
                txt_email.Text = "";

            }
            else if (opt == 3)
            {
                txt_tel.Text = "";
            }
            else if (opt == 4)
            {
                txt_adduser.Text = "";

            }
            else
            {
                txt_addpass.Text = "";
                txt_readdpass.Text = "";
                txt_nome.Text = "";
                txt_email.Text = "";
                txt_tel.Text = "";
                txt_adduser.Text = "";
                ckb_admin.Checked = false;
            }

           

        }

        private void txt_nome_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        private void txt_email_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        private void txt_tel_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        private void txt_adduser_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        private void txt_addpass_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        private void txt_readdpass_KeyDown(object sender, KeyEventArgs e)//Envia a info das textboxes para o BLL carregando ENTER nesta textbox
        {
            insUser(sender, e);
        }

        public void insUser(object sender, KeyEventArgs e)//Criada Para evitar repetir código
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLL bll = new BLL();
                int priv;
                if (ckb_admin.Checked)
                {
                    priv = 1;
                }
                else
                {
                    priv = 0;
                }
                int opt = bll.addUser(txt_nome.Text, txt_email.Text, txt_tel.Text, txt_adduser.Text, txt_addpass.Text, txt_readdpass.Text, priv);
                if (opt == 0)
                {
                    txt_addpass.Text = "";
                    txt_readdpass.Text = "";

                }
                else if (opt == 1)
                {
                    txt_nome.Text = "";

                }
                else if (opt == 2)
                {
                    txt_email.Text = "";

                }
                else if (opt == 3)
                {
                    txt_tel.Text = "";
                }
                else if (opt == 4)
                {
                    txt_adduser.Text = "";

                }
                else
                {
                    txt_addpass.Text = "";
                    txt_readdpass.Text = "";
                    txt_nome.Text = "";
                    txt_email.Text = "";
                    txt_tel.Text = "";
                    txt_adduser.Text = "";
                    ckb_admin.Checked = false;
                }
            }
        }
    }
}
