using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WebApidonNet.ORM.DAO
{
    public class EnderecoDAO
    {
        private readonly string _connectionString;


        public EnderecoDAO(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        internal bool InserirEndereco(Endereco endereco)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "INSERT INTO Endereco values(@logradouro, @numero, @complemento, @bairro, @cidade, @estado, @funcionarioId);";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                    command.Parameters.AddWithValue("@numero", endereco.Numero);
                    command.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    command.Parameters.AddWithValue("@estado", endereco.Estado);
                    command.Parameters.AddWithValue("@funcionarioId", endereco.FuncionarioId);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal bool DeletarEndereco(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "DELETE FROM Endereco WHERE Id = @id ";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal bool AtualizaEndereco(Endereco endereco)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "UPDATE Endereco SET Logradouro  = @logradouro,  Numero = @numero, Complemento = @complemento , Bairro = @bairro,  Cidade = @cidade , Estado = @estado, FuncionarioId = @funcionarioId  WHERE Id = @id";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                    command.Parameters.AddWithValue("@numero", endereco.Numero);
                    command.Parameters.AddWithValue("@complemento", endereco.Complemento);
                    command.Parameters.AddWithValue("@bairro", endereco.Bairro);
                    command.Parameters.AddWithValue("@cidade", endereco.Cidade);
                    command.Parameters.AddWithValue("@estado", endereco.Estado);
                    command.Parameters.AddWithValue("@funcionarioId", endereco.FuncionarioId);
                    command.Parameters.AddWithValue("@id", endereco.Id);
                    command.ExecuteNonQuery();

                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal DataSet RetornaEnderecos()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Logradouro,Numero,Complemento,Bairro,Cidade,Estado,FuncionarioId FROM Endereco Order by Id";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        internal DataSet RetornaEndereco(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Logradouro,Numero,Complemento,Bairro,Cidade,Estado,FuncionarioId FROM Endereco WHERE IdAluno = @id";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@id", id);

                    DataSet dtSet = new DataSet();
                    SqlDataAdapter dtAdapter = new SqlDataAdapter(command);

                    dtAdapter.Fill(dtSet);
                    return dtSet;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

