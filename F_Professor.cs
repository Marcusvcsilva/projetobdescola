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
    public partial class F_Professor : Form
    {
        F_escola f_professor;
        DataTable dt = new DataTable();
        public F_Professor(F_escola f)
        {
            InitializeComponent();
            f_professor= f;
        }

        private void F_Professor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor professor= new Professor();
            professor.nome_professor = tb_nome.Text;
            professor.birthdate_professor = tb_birthdate.Text;
            professor.email_professor = tb_email.Text;
            professor.telefone_professor = tb_telefone.Text;
            professor.sexo_professor = cb_sexo.Text;
            bd.NovoProfessor(professor); 

            
        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_birthdate.Text = "";
            tb_email.Text = "";
            tb_telefone.Text = "";
            cb_sexo.Text = ""; 
        }
    }
}
