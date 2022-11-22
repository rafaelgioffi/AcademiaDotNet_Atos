using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP.Classes
{
    class Clientes
    {
        public int CliId;
        public string CliNome;
        public string CliTel;

        public bool CadastraCli()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Clientes VALUES (@CliNome, @CliTel)";
            cmd.Parameters.Add("@CliNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@CliTel", SqlDbType.VarChar);
            cmd.Parameters[0].Value = CliNome;
            cmd.Parameters[1].Value = CliTel;

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

        public bool ExcluiCli()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Clientes WHERE CliId = @CliId";
            cmd.Parameters.Add("@CliId", SqlDbType.Int);
            cmd.Parameters[0].Value = CliId;

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

        public bool EditaCli()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Clientes SET CliNome = @CliNome, CliTel = @CliTel WHERE CliId = @CliId";
            cmd.Parameters.Add("@CliNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@CliTel", SqlDbType.Text);
            cmd.Parameters.Add("@CliId", SqlDbType.Int);
            cmd.Parameters[0].Value = CliNome;
            cmd.Parameters[1].Value = CliTel;
            cmd.Parameters[2].Value = CliId;

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

        public Clientes ConsultaCli(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection conn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Clientes", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.CliId = reader.GetInt32(0);
                        CliNome = reader.GetString(1);
                        CliTel = reader.GetString(2);

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
