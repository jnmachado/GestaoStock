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
            
        }
        public Form_Main_Admin(BLL b)
        {
            InitializeComponent();            
            dgv_stock.DataSource = b.fillDGV("tbl_stock");//Preenche a DGV
            lbl_status.Text = b.Sessao;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)//Sai da APP
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) //AINDA NAO FAZ NADA
        {

        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e) //AINDA NAO FAZ NADA
        {

        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)//Abre o form usado para adicionar users (ADMIN ONLY)
        {
            Form_Adicionar_User f = new Form_Adicionar_User();
            f.ShowDialog();
        }

      

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)//Abre o form usado para consultar os movimentos de stock (ADMIN ONLY)
        {
            Form_Consultar_Mov fs = new Form_Consultar_Mov();
            fs.Show();
        }

        private void apagarTodosToolStripMenuItem_Click(object sender, EventArgs e)//Apaga todos os movimentos de stock (ADMIN ONLY)
        {
            if (MessageBox.Show("De certeza que pertende eliminar todos os registos de movimentos?", "ATENÇÃO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//Caixa de Verificação AINDA NAO FAZ NADA
            {
                
            }
            
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)//Abre o form usado para apagar movimentos entre determinadas datas (ADMIN ONLY)
        {
            Form_Apagar_Mov fam = new Form_Apagar_Mov();
        }

        private void Form_Main_Admin_Load(object sender, EventArgs e)//NAO FAZ NADA
        {
                      

        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)//Abre o form usado para listar todos os users (ADMIN ONLY)
        {
            Form_Listar_User flu = new Form_Listar_User();
            flu.Show();
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)//Botão envia o texto da textbox para o BLL
        {
            BLL b = new BLL();
            dgv_stock.DataSource = b.procurarNaDB(stb_pesquisa.Text);

            
        }

        private void stb_pesquisa_KeyDown(object sender, KeyEventArgs e)//Permite enviar o conteudo da textbox para o BLL ao pressionar ENTER
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
