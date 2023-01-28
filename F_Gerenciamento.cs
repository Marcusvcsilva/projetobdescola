using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetinhoEscola
{
    public partial class F_Gerenciamento : Form
    {
        F_escola f_gerenciamento;
        DataTable dt = new DataTable();
        public F_Gerenciamento(F_escola f)
        {
            InitializeComponent();
            f_gerenciamento = f; 
        }

        private void F_Gerenciamento_Load(object sender, EventArgs e)
        {
            dgv_gerenciamento.DataSource = bd.ObterUserID();

            // Define a largura das colunas do DayaGridView usuario
            dgv_gerenciamento.Columns[0].Width= 40;
            dgv_gerenciamento.Columns[1].Width = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F_novouser f_novouser = new F_novouser(); 
            f_novouser.ShowDialog();
            // Atualizar o dgv com o novo usuario
            dgv_gerenciamento.DataSource = bd.ObterUserID(); 
        }
    }
}
