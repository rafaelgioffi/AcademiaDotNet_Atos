using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_11_22
{
    internal class Banco
    {
        private string conec = "Data Source=localhost;Initial Catalog=aula;" +
            "User ID=usuarioAtos;password=admin123; language=Portuguese";

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executaConsulta(string sql)
        {
            try
            {
                abrirConexao();

                 SqlCommand sqlComm = new SqlCommand(sql, cn);
                sqlComm.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                fecharConexao();
            }
        }

    }
}
