using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Classes
{
    class Notas
    {
        public string NotId;
        public string NotInfo;
        public string NotDataHora;
        public string NotTipo;
        public int CliId;
        public int ProdId;

        public bool CadastraNota()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Notas VALUES (@NotId, @NotInfo, @NotDataHora, @NotTipo, @CliId, @ProdId)";
            cmd.Parameters.Add("@NotId", SqlDbType.VarChar);
            cmd.Parameters.Add("@NotInfo", SqlDbType.VarChar);
            cmd.Parameters.Add("@NotDataHora", SqlDbType.VarChar);
            cmd.Parameters.Add("@NotTipo", SqlDbType.VarChar);
            cmd.Parameters.Add("@CliId", SqlDbType.Int);
            cmd.Parameters.Add("@ProdId", SqlDbType.Int);
            cmd.Parameters[0].Value = NotId;
            cmd.Parameters[1].Value = NotInfo;
            cmd.Parameters[2].Value = NotDataHora;
            cmd.Parameters[3].Value = NotTipo;
            cmd.Parameters[4].Value = CliId;
            cmd.Parameters[5].Value = ProdId;

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

        public bool ExcluiNot()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Notas WHERE NotId = @NotId";
            cmd.Parameters.Add("@NotId", SqlDbType.VarChar);
            cmd.Parameters[0].Value = NotId;

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

        public bool EditaNot()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Notas SET NotInfo = @NotInfo WHERE NotId = @NotId";
            cmd.Parameters.Add("@NotInfo", SqlDbType.VarChar);                       
            cmd.Parameters.Add("@NotId", SqlDbType.VarChar);
            cmd.Parameters[0].Value = NotInfo;                      
            cmd.Parameters[1].Value = NotId;

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

        public Notas ConsultaNot(string id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection conn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Notas", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetString(0) == id)
                    {
                        this.NotId = reader.GetString(0);
                        NotInfo = reader.GetString(1);
                        NotDataHora = reader.GetString(2);
                        NotTipo = reader.GetString(3);
                        CliId = reader.GetInt32(4);
                        ProdId = reader.GetInt32(5);

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
