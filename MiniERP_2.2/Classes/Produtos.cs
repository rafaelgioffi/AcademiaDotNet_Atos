using System.Data;
using System.Data.SqlClient;

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


        public bool CadastraProd()
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

        public bool ExcluiProd()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Produtos WHERE ProdId = @ProdId";
            cmd.Parameters.Add("@ProdId", SqlDbType.Int);
            cmd.Parameters[0].Value = ProdId;

            try
            {
                cmd.ExecuteNonQuery();
                trans.Commit();

                return true;
            }
            catch (Exception e)
            {
                trans.Rollback();

                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool EditaProd()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Produtos SET FornId = @FornId, ProdNome = @ProdNome, ProdDesc = @ProdDesc, ProdValUnit = @ProdValUnit, ProdQuant = @ProdQuant WHERE ProdId = @ProdId";
            cmd.Parameters.Add("@FornId", SqlDbType.Int);
            cmd.Parameters.Add("@ProdNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@ProdDesc", SqlDbType.Text);
            cmd.Parameters.Add("@ProdValUnit", SqlDbType.Decimal);
            cmd.Parameters.Add("@ProdQuant", SqlDbType.Int);
            cmd.Parameters.Add("@ProdId", SqlDbType.Int);
            cmd.Parameters[0].Value = FornId;
            cmd.Parameters[1].Value = ProdNome;
            cmd.Parameters[2].Value = ProdDesc;
            cmd.Parameters[3].Value = ProdValUnit;
            cmd.Parameters[4].Value = ProdQuant;
            cmd.Parameters[5].Value = ProdId;

            try
            {
                cmd.ExecuteNonQuery();
                trans.Commit();

                return true;
            }
            catch (Exception e)
            {
                trans.RollbackAsync();

                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public Produtos ConsultaProd(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection conn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Produtos", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.ProdId = reader.GetInt32(0);
                        FornId = reader.GetInt32(1);
                        ProdNome = reader.GetString(2);
                        ProdDesc = reader.GetString(3);
                        ProdValUnit = reader.GetFloat(4);
                        ProdQuant = reader.GetInt32(5);

                        return this;
                    }
                }

                return null;
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                bd.fecharConexao();
            }
        }



    }
}
