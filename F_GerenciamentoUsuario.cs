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
    public partial class F_GerenciamentoUsuario : Form
    {
        F_escola f_gerenciamento;
        DataTable dt = new DataTable();
        public F_GerenciamentoUsuario(F_escola f)
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

        private void dgv_gerenciamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void F_Gerenciamento_SizeChanged(object sender, EventArgs e)
        {

        }

        private void dgv_gerenciamento_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count; 
            // Realize o procedimento caso tenha ao menos uma linha selecionada 
            if (qtdLinhas > 0 )
            {
                // Quando obtiver os dados do banco de dados precisaremos de a.....
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário 
                string userId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = bd.ObterUsuarioPorId(userId);
                
                tb_id.Text = dt.Rows[0].Field<Int64>("id_usuario").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_usuario").ToString();
                tb_username.Text = dt.Rows[0].Field<string>("username_usuario").ToString(); 
                tb_senha.Text = dt.Rows[0].Field<string>("senha_usuario").ToString() ;
                cb_status.Text = dt.Rows[0].Field<string>("status_usuario").ToString();
                numupdn_nivel.Text = dt.Rows[0].Field<Int64>("nivel_usuario").ToString(); 
            }
        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_gerenciamento.SelectedRows[0].Index; 

            Usuario user = new Usuario();
            user.id_usuario = Convert.ToInt32(tb_id.Text);
            user.nome_usuario = tb_nome.Text;
            user.username_usuario = tb_username.Text;
            user.senha_usuario = tb_senha.Text;
            user.status_usuario = cb_status.Text;
            user.nivel_usuario = Convert.ToInt32(Math.Round(numupdn_nivel.Value,0l));
            // Invocar o método 
            bd.AtualizarDados(user);

            //Atualizar o DGV com os dados atuais 
            // dgv_gerenciamento.DataSource = bd.ObterUserId(); 
            //Setar a linha selecionada anteriormente 
            // dgv_usuario.CurrentCell = dgv_usuario[0,linha]; 

            // Outra forma de fazer a mesma coisa sem carregar todos os dados do BD

            dgv_gerenciamento[1,linha].Value = tb_nome.Text;
            
           
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Usuário", MessageBoxButtons.YesNo); 
            if (resposta == DialogResult.Yes)
            {
                bd.RemoverUsuario(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv
                dgv_gerenciamento.Rows.Remove(dgv_gerenciamento.CurrentRow); 
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_nome.Text = "";
            tb_username.Text = "";
            tb_senha.Text = "";
            cb_status.Text = "";
            numupdn_nivel.Text = "";
        }
    }
}
