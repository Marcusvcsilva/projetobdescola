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
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
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
                    cmd.CommandText = "SELECT * FROM tb_usuarios";
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

