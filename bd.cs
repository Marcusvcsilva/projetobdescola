using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Linq.Expressions;

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
                MessageBox.Show("Usuario já existe no sistema");
                return;
            }
            // Rotina para inserção do novo usuário no banco de dados. 
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                // Parametros conforme a tabela do banco de dados 
                cmd.CommandText = "INSERT INTO tb_usuario (nome_usuario, username_usuario, senha_usuario, status_usuario, nivel_usuario) VALUES (@nome, @username, @senha, @status, @nivel)";

                cmd.Parameters.AddWithValue("@nome", user.nome_usuario);
                cmd.Parameters.AddWithValue("@username", user.username_usuario);
                cmd.Parameters.AddWithValue("@senha", user.senha_usuario);
                cmd.Parameters.AddWithValue("@status", user.status_usuario);
                cmd.Parameters.AddWithValue("@nivel", user.nivel_usuario); 

                cmd.ExecuteNonQuery();
                vcon.Close();
                MessageBox.Show("Novo usuário adicionado com sucesso");

            }
                catch (Exception ex)
            {

                MessageBox.Show("Erro ao inserir novo usuario" + ex.Message);
            }
            }

        public static void NovoCurso(Curso curso)
        {

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            // Parametros a seguir conforme a tabela no banco de dados 
            cmd.CommandText = "INSERT INTO tb_curso (nome_curso, area_curso, status_curso) VALUES (@nome, @area, @status)";

            cmd.Parameters.AddWithValue("@nome", curso.nome_curso);
            cmd.Parameters.AddWithValue("@area", curso.area_curso);
            cmd.Parameters.AddWithValue("@status", curso.status_curso);

            cmd.ExecuteNonQuery();
            vcon.Close();
            MessageBox.Show("Novo curso adicionado com sucesso"); 
        } // Fim do método novo curso 

        public static void NovoProfessor(Professor professor)
        {
            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            // Parametros a seguir conforme a tabela no banco de dados 
            cmd.CommandText = "INSERT INTO tb_professor (nome_professor, birthdate_professor, email_professor, telefone_professor, sexo_professor) VALUES (@nome, @birthdate, @email, @telefone, @sexo)";
                
            cmd.Parameters.AddWithValue("@nome", professor.nome_professor);
            cmd.Parameters.AddWithValue("@birthdate", professor.birthdate_professor);
            cmd.Parameters.AddWithValue("@email", professor.email_professor);
            cmd.Parameters.AddWithValue("@telefone", professor.telefone_professor);
            cmd.Parameters.AddWithValue("@sexo", professor.sexo_professor);

            cmd.ExecuteNonQuery();
            vcon.Close();
            MessageBox.Show("Novo professor adicionado com sucesso"); 
        }   //Fim do método professor 

        public static void NovoAluno(Aluno aluno)
        {
            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            // Parametros a seguir conforme a tabela no banco de dados
            cmd.CommandText = "INSERT INTO tb_aluno (nome_aluno, email_aluno, telefone_aluno, cpf_aluno, rg_aluno, sexo_aluno, senha_aluno, cep_aluno, endereco_aluno, numero_aluno) VALUES (@nome, @email, @telefone, @cpf, @rg, @sexo, @senha, @cep, @endereco, @numero)";

            cmd.Parameters.AddWithValue("@nome", aluno.nome_aluno);
            cmd.Parameters.AddWithValue("@email", aluno.email_aluno);
            cmd.Parameters.AddWithValue("@telefone", aluno.telefone_aluno);
            cmd.Parameters.AddWithValue("@cpf", aluno.cpf_aluno);
            cmd.Parameters.AddWithValue("@rg", aluno.rg_aluno);
            cmd.Parameters.AddWithValue("@sexo", aluno.sexo_aluno);
            cmd.Parameters.AddWithValue("@senha", aluno.senha_aluno);
            cmd.Parameters.AddWithValue("@cep", aluno.cep_aluno);
            cmd.Parameters.AddWithValue("@endereco", aluno.endereco_aluno);
            cmd.Parameters.AddWithValue("@numero", aluno.numero_aluno);

            cmd.ExecuteNonQuery();
            vcon.Close();
            MessageBox.Show("Novo professor adicionado com sucesso"); 
            }//Fim do método aluno   

        public static bool UsernameExiste(Usuario user)
        {
            bool resposta;
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            var vcon = ConectarBanco();
            var cmd = vcon.CreateCommand();
            cmd.CommandText = "SELECT username_usuario FROM tb_usuario WHERE username_usuario='" + user.username_usuario + "'";
            da = new SQLiteDataAdapter(cmd.CommandText, vcon);
            //o Data adapter abaixo preeche o DataTable com as informações retornadas do banco de dados
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {



                resposta = true;

            }
            else
            {



                resposta = false;
            }
            vcon.Close();
            return resposta;

        } // Fim do método UsernameExiste
          

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

        public static DataTable ObterUserID()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConectarBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = "SELECT id_usuario as ID, nome_usuario AS Nome FROM tb_usuario";
                da = new SQLiteDataAdapter(cmd.CommandText, vcon);
                // O Data adapter abaixo preenche o DataTable com as informações retornadas do banco de dados
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            }
        }
    }


