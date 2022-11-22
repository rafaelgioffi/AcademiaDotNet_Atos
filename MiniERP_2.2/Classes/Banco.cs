using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Banco
    {
        private string conexaoString = ConfigurationManager.ConnectionStrings["MiniErpSettings"].ConnectionString;
        
        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conexaoString);
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

        public DataTable Consulta(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand query = new SqlCommand(sql, cn);
                query.ExecuteNonQuery();

                SqlDataAdapter adapter = new SqlDataAdapter(query);
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
