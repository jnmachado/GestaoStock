using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace GestaoStock
{
    class BLL
    {
        private DAL d = new DAL();
        public bool validaLogin(string user, string passwd)
        {
            if (d.login(user, passwd) == 1)
            {
                if(d.isAdmin(user))
                {
                    Form_Main_Admin f = new Form_Main_Admin();
                    f.Show();
                   
                    return true;
                }
                else
                {
                    Form_Main_User fmu = new Form_Main_User();
                    fmu.Show();
                    
                    return true;
                }
            }
            else
            {
                MessageBox.Show("Login Incorrecto");
                return false;
            }            
        }

        public int addUser(string nome, string email, string tel, string user, string pass, string repass, int priv)
        {
            if(pass == repass && pass.Length > 0)
            {
                if(Regex.IsMatch(nome, @"^[\p{L}\p{M}' \.\-]+$"))
                {
                    try
                    {
                        MailAddress mail = new MailAddress(email);
                        if (mail.Address.Length > 0)
                        {
                            if(int.Parse(tel) > 0)
                            {
                                if(user.Length > 0)
                                {
                                    if(d.userExist(user) == 0)
                                    {
                                        d.inserirUser(nome, email, int.Parse(tel), user, pass, priv);
                                        MessageBox.Show("Utilizador adicionado com sucesso.");
                                        return 5;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Já existe um utilizador com esse username. Por favor, insira outro username.");
                                        return 4;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Por favor, insira um username válido.");
                                    return 4;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Por favor, insira um número telefónico válido.");
                                return 3;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, insira um e-mail válido");
                            return 2;
                        }
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("Por favor, insira um e-mail válido: " + e.Message);
                        return 2;
                    }


                }
                else
                {
                    MessageBox.Show("Por favor, insira um nome válido.");
                    return 1;
                }
               
            }
            else
            {
                MessageBox.Show("As passwords não são iguais. Tente novamente.");
                return 0;
            }

        }

        public DataTable fillDGV(string tabela)
        {
            string cmd = "SELECT * FROM " + tabela + ";";
            return d.preencherDGV(cmd);

        }

        public DataTable procurarNaDB(string pesquisa)
        {
            string cmd = "SELECT * FROM tbl_stock WHERE ref LIKE '%" + pesquisa + "%' OR qtd LIKE '%" + pesquisa + "%' OR qtd_min LIKE '%" + pesquisa + "%' OR custo_uni LIKE '%" + pesquisa + "%' OR pvp_uni LIKE '%" + pesquisa + "%' OR nome LIKE '%" + pesquisa + "%';";
            return d.preencherDGV(cmd);
        }

    }
}
