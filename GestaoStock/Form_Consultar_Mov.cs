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
    public partial class Form_Consultar_Mov : Form
    {
        public Form_Consultar_Mov()//Preenche a DGV com todos os Movimentos
        {
            InitializeComponent();
            BLL bl = new BLL();
            dgv_mov.DataSource = bl.fillDGV("tbl_mov");
        }

        private void Form_Consultar_Mov_Load(object sender, EventArgs e)//NÃO FAZ NADA
        {
            
            

        }
    }
}
