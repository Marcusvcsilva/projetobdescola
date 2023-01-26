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
    public partial class F_Curso : Form
    {
        F_escola f_curso;
        DataTable dt = new DataTable();
        public F_Curso( F_escola f)
        {
            InitializeComponent();
            f_curso = f;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void F_Curso_Load(object sender, EventArgs e)
        {

        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Curso curso = new Curso();
            curso.nome_curso = tb_nome.Text;
            curso.area_curso = cb_area.Text;
            curso.status_curso = cb_status.Text;
            bd.NovoCurso(curso);
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            cb_area.Text = "";
            cb_status.Text = ""; 
        }
    }
}
