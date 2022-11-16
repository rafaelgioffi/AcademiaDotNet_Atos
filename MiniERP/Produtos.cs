using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Produtos
    {
        public int ProdId;
        public int FornId;
        public string ProdNome;
        public string ProdDesc;
        public float ProdValUnit;
        public int ProdQuant;

        public bool cadastrarProduto()
        {
            Banco bd = new Banco();
            SqlConnection conn = bd.abrirConexao();

            SqlTransaction trans = conn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Produtos VALUES (@FornId, @ProdNome, @ProdDesc, @ProdValUnit, @ProdQuant)";
            cmd.Parameters.Add("@FornId", SqlDbType.Int);
            cmd.Parameters.Add("@ProdNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@ProdDesc", SqlDbType.VarChar);
            cmd.Parameters.Add("@ProdValUnit", SqlDbType.Decimal);
            cmd.Parameters.Add("@ProdQuant", SqlDbType.Int);
            cmd.Parameters[0].Value = FornId;
            cmd.Parameters[1].Value = ProdNome;
            cmd.Parameters[2].Value = ProdDesc;
            cmd.Parameters[3].Value = ProdValUnit;
            cmd.Parameters[4].Value = ProdQuant;

            try
            {
                cmd.ExecuteNonQuery();
                trans.Commit();

                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();

                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

    }
}
