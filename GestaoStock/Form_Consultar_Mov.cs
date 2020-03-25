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
        public Form_Consultar_Mov()
        {
            InitializeComponent();
            BLL bl = new BLL();
            dgv_mov.DataSource = bl.fillDGV("tbl_mov");
        }

        private void Form_Consultar_Mov_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'baseDadosDataSet2.tbl_mov' table. You can move, or remove it, as needed.
            

        }
    }
}
