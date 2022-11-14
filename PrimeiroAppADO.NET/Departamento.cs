using System.Data;
using System.Data.SqlClient;

namespace PrimeiroAppADO.NET
{
    internal class Departamento
    {
        private string nome;
        private string localizacao;
        private string orcamento;

        public Departamento(string nome, string localizacao, string orcamento)
        {
            this.nome = nome;
            this.localizacao = localizacao;
            this.orcamento = orcamento;
        }

        public bool gravarDepartamento()
        {
            Banco b = new Banco();
            SqlConnection cn = b.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "INSERT INTO Departamento VALUES(@nome, @localizacao, @orcamento);";
            cmd.Parameters.Add("@nome", SqlDbType.VarChar);
            cmd.Parameters.Add("@localizacao", SqlDbType.VarChar);
            cmd.Parameters.Add("@orcamento", SqlDbType.VarChar);
            cmd.Parameters[0].Value = nome;
            cmd.Parameters[1].Value = localizacao;
            cmd.Parameters[2].Value = orcamento;

            try
            {
                cmd.ExecuteNonQuery();
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
                b.fecharConexao();
            }
        }
    }
}
