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
    public partial class F_Aluno : Form
    {
        
        public F_Aluno()
        {
            InitializeComponent();
            
        }

        private void lb_email_Click(object sender, EventArgs e)
        {

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.nome_aluno = tb_nome.Text; 
            aluno.email_aluno = tb_email.Text;
            aluno.telefone_aluno=tb_telefone.Text;
            aluno.cpf_aluno= tb_cpf.Text;
            aluno.rg_aluno= tb_rg.Text;
            aluno.sexo_aluno = cb_sexo.Text;
            aluno.cep_aluno = tb_cep.Text;
            aluno.endereco_aluno = tb_endereco.Text;
            bd.NovoAluno(aluno); 
        }

        private void tb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Aluno_Load(object sender, EventArgs e)
        {

        }

        private void tb_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_senha_Click(object sender, EventArgs e)
        {

        }
    }
}
