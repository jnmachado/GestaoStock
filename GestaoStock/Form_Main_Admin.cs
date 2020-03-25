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
    public partial class Form_Main_Admin : Form
    {
        public Form_Main_Admin()
        {
            InitializeComponent();
            BLL bl = new BLL();
            dgv_stock.DataSource = bl.fillDGV("tbl_stock");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Adicionar_User f = new Form_Adicionar_User();
            f.ShowDialog();
        }

      

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Consultar_Mov fs = new Form_Consultar_Mov();
            fs.Show();
        }

        private void apagarTodosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("De certeza que pertende eliminar todos os registos de movimentos?", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
            
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Apagar_Mov fam = new Form_Apagar_Mov();
        }

        private void Form_Main_Admin_Load(object sender, EventArgs e)
        {
                      

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Listar_User flu = new Form_Listar_User();
            flu.Show();
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            BLL b = new BLL();
            dgv_stock.DataSource = b.procurarNaDB(stb_pesquisa.Text);

            
        }

        private void stb_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BLL b = new BLL();
                dgv_stock.DataSource = b.procurarNaDB(stb_pesquisa.Text);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
