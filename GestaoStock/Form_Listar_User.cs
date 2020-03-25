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
    public partial class Form_Listar_User : Form
    {
        public Form_Listar_User() //Preenche o DGV com todos os utilizadores da BD
        {
            InitializeComponent();
            BLL bl = new BLL();
            dgv_user.DataSource = bl.fillDGV("tbl_login");
        }

        private void Form_Listar_User_Load(object sender, EventArgs e)//NÃO FAZ NADA
        {
            
            

        }

        private void btn_atual_Click(object sender, EventArgs e)//Dá refresh à DGV
        {
            dgv_user.Refresh();
        }
    }
}
