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
    public partial class F_GerenciamentoAluno : Form
    {
        F_escola f_gerenciamentoaluno;
        DataTable dt = new DataTable();
        public F_GerenciamentoAluno(F_escola f)
        {
            InitializeComponent();
            f_gerenciamentoaluno = f;
        }

        private void F_GerenciamentoAluno_Load(object sender, EventArgs e)
        {
            dgv_gerenciamentoaluno.DataSource = bd.ObterAlunoID();

            // Define a largura das colunas do DayaGridView usuario
            dgv_gerenciamentoaluno.Columns[0].Width = 40;
            dgv_gerenciamentoaluno.Columns[1].Width = 100;
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            F_Aluno f_aluno = new F_Aluno();
            f_aluno.ShowDialog();
            // Atualizar o dgv com o novo usuario
            dgv_gerenciamentoaluno.DataSource = bd.ObterAlunoID();
        }

        private void dgv_gerenciamentoaluno_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada 
            if (qtdLinhas > 0)
            {
                // Quando obtiver os dados do banco de dados precisaremos de a.....
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário 
                string alunoId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = bd.ObterAlunoPorId(alunoId);

                tb_id.Text = dt.Rows[0].Field<Int64>("id_aluno").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_aluno").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("email_aluno").ToString();
                tb_telefone.Text = dt.Rows[0].Field<string>("telefone_aluno").ToString();
                tb_cpf.Text = dt.Rows[0].Field<string>("cpf_aluno").ToString();
                tb_rg.Text = dt.Rows[0].Field<string>("rg_aluno").ToString();
                cb_sexo.Text = dt.Rows[0].Field<string>("sexo_aluno").ToString();
                tb_cep.Text = dt.Rows[0].Field<string>("cep_aluno").ToString();
                tb_endereco.Text = dt.Rows[0].Field<string>("endereco_aluno").ToString();

            }
        }

        private void dgv_gerenciamentoaluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_gerenciamentoaluno.SelectedRows[0].Index;

            Aluno aluno = new Aluno();
            aluno.id_aluno = Convert.ToInt32(tb_id.Text);
            aluno.nome_aluno = tb_nome.Text;
            aluno.email_aluno = tb_email.Text;
            aluno.telefone_aluno = tb_telefone.Text;
            aluno.cpf_aluno = tb_cpf.Text;
            aluno.rg_aluno = tb_rg.Text;
            aluno.sexo_aluno = cb_sexo.Text; 
            aluno.cep_aluno = tb_cep.Text;
            aluno.endereco_aluno = tb_endereco.Text;


            // Invocar o método 
            bd.AtualizarDadosAluno(aluno);

            //Atualizar o DGV com os dados atuais 
            // dgv_gerenciamento.DataSource = bd.ObterUserId(); 
            //Setar a linha selecionada anteriormente 
            // dgv_usuario.CurrentCell = dgv_usuario[0,linha]; 

            // Outra forma de fazer a mesma coisa sem carregar todos os dados do BD

            dgv_gerenciamentoaluno[1, linha].Value = tb_nome.Text;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_id.Text = "";
            tb_nome.Text = "";
            tb_email.Text = "";
            tb_telefone.Text = "";
            tb_cpf.Text = "";
            tb_rg.Text = "";
            cb_sexo.Text = "";
            tb_cep.Text = "";
            tb_endereco.Text = "";
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Aluno", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                bd.RemoverAluno(tb_id.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv
                dgv_gerenciamentoaluno.Rows.Remove(dgv_gerenciamentoaluno.CurrentRow);
            }
        }
    }
}

