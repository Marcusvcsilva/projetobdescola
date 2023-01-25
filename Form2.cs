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
    public partial class F_novouser : Form
    {
        F_escola f_novouser;
        public F_novouser(F_escola f)
        {
            InitializeComponent();
            f_novouser = f;
        }

        private void F_novouser_Load(object sender, EventArgs e)
        {

        }

        private void bt3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.nome_usuario = tb_nome.Text; 
            usuario.username_usuario = tb_user.Text;
            usuario.senha_usuario = tb_senha.Text;
            usuario.status_usuario = cb_status.Text;
            //usuario.nivel_usuario = (int32)nud_nivel.Value; 
            usuario.nivel_usuario = Convert.ToInt32(Math.Round(numupdn_nivel.Value,0));
          //bd.NovoUser(usuario);

            // string dados = "Dados .: " + usuario.nome_usuario + " " + 
            // usuario.username_usuario = " "+ usuario.senha_usuario+ " " + usuario.status
            // MessageBox.Show(dados); 


        }
    }
}
