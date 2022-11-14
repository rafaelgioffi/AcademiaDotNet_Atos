using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace PrimeiroAppADO.NET
{
    internal class Empregados
    {
        public string nome;
        public int? idGerente;
        public string funcao;
        public int idDepartamento;
        public string admissao;
        public decimal? salario;
        public decimal? comissao;
               

        public bool gravarEmpregado()
        {
            Banco banco = new Banco();
            SqlConnection conn = banco.abrirConexao();
            SqlTransaction tran = conn.BeginTransaction();
            SqlCommand com = new SqlCommand();
            com.Connection = conn;
            com.Transaction = tran;
            com.CommandType = CommandType.Text;

            com.CommandText = "INSERT INTO Empregado VALUES(@nome, @idGerente, @funcao, @idDepartamento, @admissao, @salario, @comissao);";
            com.Parameters.Add("@nome", SqlDbType.VarChar);
            com.Parameters.Add("@idGerente", SqlDbType.Int);
            com.Parameters.Add("@funcao", SqlDbType.VarChar);
            com.Parameters.Add("@idDepartamento", SqlDbType.Int);
            com.Parameters.Add("@admissao", SqlDbType.VarChar);
            com.Parameters.Add("@salario", SqlDbType.Decimal);
            com.Parameters.Add("@comissao", SqlDbType.Decimal);
            com.Parameters[0].Value = nome;
            com.Parameters[1].Value = idGerente ?? SqlInt32.Null;
            com.Parameters[2].Value = funcao;
            com.Parameters[3].Value = idDepartamento;
            com.Parameters[4].Value = admissao;
            com.Parameters[5].Value = salario;
            com.Parameters[6].Value = comissao ?? SqlDecimal.Null;

            try
            {
                com.ExecuteNonQuery();
                tran.Commit();                
                return true;
            }
            catch (Exception e)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                banco.fecharConexao();
            }
        }


    }

}
