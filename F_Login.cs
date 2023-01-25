
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ProjetinhoEscola
{
    public partial class F_Login : Form
    {
        F_escola f_login;
        DataTable dt = new DataTable();
        public F_Login( F_escola f)
        {
            InitializeComponent();
            f_login = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoncancelar_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = tb_user.Text;
            string senha = tbsenha.Text;
            if (username == "" || senha == "")
            {
                MessageBox.Show("Preencha todos os campos");
                tb_user.Focus();
                return;
            } // Fim do if

            //string sql = "SELECT * FROM tb_usuario WHERE username_usuario='"+username+"' AND senha_usuario='"+senha+"'";

            //string sql =  "select * from tb_usuario where username_usuario = 'diogo' and senha_usuario = 1234";
            string sql = "SELECT * FROM tb_usuario WHERE username_usuario='" + username + "' AND senha_usuario='" + senha + "'";
            dt = bd.ConsultaSql(sql);

            if (dt.Rows.Count == 1)
            {
                // O ItemArray lista na ordem do bd Ex: Item 5 é o nivel do user 
                f_login.lbnivel.Text = dt.Rows[0].ItemArray[5].ToString();
                // Segunda forma de obter os dados do DataTable 
                f_login.lbuser.Text = dt.Rows[0].Field<string>("username_usuario");
                f_login.pb_login.Image = Properties.Resources.bverde;
                // Set para classe global 
                Globais.nível = int.Parse(dt.Rows[0].Field<Int64>("nivel_usuario").ToString());
                Globais.logado = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos"); 
            }



        }

    }
}
