using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace ProjetinhoEscola
{
    internal class bd
    {
        private static SQLiteConnection conex;
        private static SQLiteConnection ConectarBanco()
        {
            //conex = new SQLiteConnection("Data Source=C:\\Users\\marcus.vcsilva22
            //conex = new SQLiteConnection("Data Source=C:\\Users\\marcus.vcsilva22
            //Definindo caminho relativo para o Banco de Dados
            conex = new SQLiteConnection("Data Source=" + Globais.caminhoBanco);

            conex.Open();
            return conex;
        } // Fim do método ConectarBanco

        public static DataTable RelacaoUsuario()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = ConectarBanco().CreateCommand();
                {
                    cmd.CommandText = "SELECT * FROM tb_usuario";
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Método genérico para consulta no BD | DQL - Data Query Language 

        public static DataTable ConsultaSql(string sql)
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                var vcon = ConectarBanco();
                var cmd = ConectarBanco().CreateCommand();
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    da.Fill(dt);
                    vcon.Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        // Fim das Funçoes Genéricas

        // Função para F_NovoUser Item 9.2 do Material de Apoio 

        public static void NovoUser(Usuario user)
        {
            if (UsernameExiste(user) == true)
            {
                MessageBox.Show("Usuario já existe no sistema ");
                return;
            }
            // Rotina para inserção do novo usuário no banco de dados. 
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                // Parametros conforme a tabela do banco de dados 
                cmd.CommandText = "INSERT INTO tb_usuarios (nome_usuario, username_usuario, senha_usuario, status_usuario, nivel_usuario) VALUES (@nome, @username, @senha, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
                cmd.Parameters.AddWithValue("@username", user.username_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario); 

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");

            }
                catch(Exception ex)
            {

                MessageBox.Show("Erro ao inserir novo usuario 
            }
            }

        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null; 
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuarios WHERE username_usuario='" + user.username_usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon); 
            // o Data adaptar abaixo preenche o DataTable com as informaçoes retornadas do banco de dados
        }
    

        public static void Dml(string sql, string msgOk = null, string msgErro=null) // Data Manipulation Language (INSERT - UPDADE - DELETE)
        { 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

                try
                {
                    var vcon = ConectarBanco();
                    var cmd = vcon.CreateCommand();
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                    // o Data adapter 
                    cmd.ExecuteNonQuery();
                    vcon.Close();
                    if (msgOk != null) { MessageBox.Show(msgOk); }

                }
                catch (Exception ex)
                {
                    if (msgErro != null) {MessageBox.Show(msgErro + " " + ex.Message); }
                    throw ex;


                }

            }

        }
    }
}

