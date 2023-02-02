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
    public partial class F_escola : Form
    {
        public F_escola()
        {
            InitializeComponent();
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void logooofToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Login f_login = new F_Login(this);
            f_login.ShowDialog();
        }

        private void lbuser_Click(object sender, EventArgs e)
        {

        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_novouser f_novouser = new F_novouser();
            f_novouser.ShowDialog();
        }

        private void novoCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Curso f_curso = new F_Curso(this);
            f_curso.ShowDialog();
        }

        private void novoProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Professor f_professor = new F_Professor(this);
            f_professor.ShowDialog();
        }

        private void novoAlunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Aluno f_aluno = new F_Aluno();
            f_aluno.ShowDialog(); 
        }

        private void gerenciamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_GerenciamentoUsuario f_gerenciamento = new F_GerenciamentoUsuario(this);
            f_gerenciamento.ShowDialog(); 
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void gerenciamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_GerenciamentoAluno f_gerenciamentoaluno = new F_GerenciamentoAluno(this);
            f_gerenciamentoaluno.ShowDialog();
        }
    }
}
