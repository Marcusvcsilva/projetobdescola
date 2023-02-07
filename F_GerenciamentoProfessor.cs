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
    public partial class F_GerenciamentoProfessor : Form
    {
        F_escola f_gerenciamentoprofessor;
        DataTable dt = new DataTable(); 
        public F_GerenciamentoProfessor(F_escola f)
        {
            InitializeComponent();
            f_gerenciamentoprofessor = f;
        }

        private void dgv_gerenciamentoprofessor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_gerenciamentoprofessor_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int qtdLinhas = dgv.SelectedRows.Count;
            // Realize o procedimento caso tenha ao menos uma linha selecionada 
            if (qtdLinhas > 0)
            {
                // Quando obtiver os dados do banco de dados precisaremos de a.....
                DataTable dt = new DataTable();

                // O dado da coluna indice 0 é o Id do usuário 
                string professorId = dgv.SelectedRows[0].Cells[0].Value.ToString();
                dt = bd.ObterProfessorPorId(professorId);

                tb_idprofessor.Text = dt.Rows[0].Field<Int64>("id_professor").ToString();
                tb_nome.Text = dt.Rows[0].Field<string>("nome_professor").ToString();
                tb_birthdate.Text = dt.Rows[0].Field<string>("birthdate_professor").ToString();
                tb_email.Text = dt.Rows[0].Field<string>("email_professor").ToString();
                tb_telefone.Text = dt.Rows[0].Field<string>("telefone_professor").ToString();
                cb_sexo.Text = dt.Rows[0].Field<string>("sexo_professor").ToString();

            }
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {

        }

        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            int linha = dgv_gerenciamentoprofessor.SelectedRows[0].Index;

            Professor professor = new Professor();
            professor.id_professor = Convert.ToInt32(tb_idprofessor.Text);
            professor.nome_professor = tb_nome.Text;
            professor.birthdate_professor = tb_birthdate.Text;
            professor.email_professor = tb_email.Text;
            professor.telefone_professor = tb_telefone.Text;
            professor.sexo_professor = cb_sexo.Text;

            // Invocar o método 
            bd.AtualizarDadosProfessor(professor);

            //Atualizar o DGV com os dados atuais 
            // dgv_gerenciamento.DataSource = bd.ObterUserId(); 
            //Setar a linha selecionada anteriormente 
            // dgv_usuario.CurrentCell = dgv_usuario[0,linha]; 

            // Outra forma de fazer a mesma coisa sem carregar todos os dados do BD

            dgv_gerenciamentoprofessor[1, linha].Value = tb_nome.Text;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_idprofessor.Text = "";
            tb_nome.Text = "";
            tb_birthdate.Text = "";
            tb_email.Text = "";
            tb_telefone.Text = "";
            cb_sexo.Text = ""; 
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Confirmar Exclusão ?", "Excluir Aluno", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                bd.RemoverProfessor(tb_idprofessor.Text);
                // Para evitar carregar o banco de dados novamente podemos atualizar o dgv
                dgv_gerenciamentoprofessor.Rows.Remove(dgv_gerenciamentoprofessor.CurrentRow);
            }
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F_GerenciamentoProfessor_Load(object sender, EventArgs e)
        {
            dgv_gerenciamentoprofessor.DataSource = bd.ObterProfessorID();

            // Define a largura das colunas do DayaGridView Professor
            dgv_gerenciamentoprofessor.Columns[0].Width = 40;
            dgv_gerenciamentoprofessor.Columns[1].Width = 100;
        }
    }
}
