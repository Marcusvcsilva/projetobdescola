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
    public partial class F_GerenciamentoCurso : Form
    {
        F_GerenciamentoCurso f_gerenciamentocurso;
        DataTable dt = new DataTable();
        public F_GerenciamentoCurso(F_escola f)
        {
            InitializeComponent();
           
        }

        private void F_GerenciamentoCurso_Load(object sender, EventArgs e)
        {
            
        }
    }
}
