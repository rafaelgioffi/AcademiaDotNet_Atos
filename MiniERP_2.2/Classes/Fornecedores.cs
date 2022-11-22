using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Fornecedores
    {        
        public int FornId;
        public string FornNome;
        public string FornCnpj;        

        public bool CadastraForn()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Fornecedores VALUES (@FornNome, @FornCnpj)";           
            cmd.Parameters.Add("@FornNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@FornCnpj", SqlDbType.VarChar);            
            cmd.Parameters[0].Value = FornNome;
            cmd.Parameters[1].Value = FornCnpj;            

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

        public bool ExcluiForn()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM Fornecedores WHERE FornId = @FornId";
            cmd.Parameters.Add("@FornId", SqlDbType.Int);
            cmd.Parameters[0].Value = FornId;

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

        public bool EditaForn()
        {
            Banco bd = new Banco();

            SqlConnection conn = bd.abrirConexao();
            SqlTransaction trans = conn.BeginTransaction();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = conn;
            cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE Fornecedores SET FornNome = @FornNome, FornCnpj = @FornCnpj WHERE FornId = @FornId";            
            cmd.Parameters.Add("@FornNome", SqlDbType.VarChar);
            cmd.Parameters.Add("@FornCnpj", SqlDbType.Text);            
            cmd.Parameters.Add("@FornId", SqlDbType.Int);            
            cmd.Parameters[0].Value = FornNome;
            cmd.Parameters[1].Value = FornCnpj;            
            cmd.Parameters[2].Value = FornId;

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

        public Fornecedores ConsultaForn(int id)
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection conn = bd.abrirConexao();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Fornecedores", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader.GetInt32(0) == id)
                    {
                        this.FornId = reader.GetInt32(0);                        
                        FornNome = reader.GetString(1);
                        FornCnpj = reader.GetString(2);                        

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
