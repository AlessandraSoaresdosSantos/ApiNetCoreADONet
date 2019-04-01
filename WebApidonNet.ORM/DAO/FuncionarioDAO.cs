using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApidonNet.ORM.DAO
{
    public class FuncionarioDAO
    {
        private readonly string _connectionString;


        public FuncionarioDAO(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        internal bool InserirFuncionario(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "INSERT INTO Funcionario values(@nome , @cpf , @rg ,@telefone , @enderecoId , @departamentoId);";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@nome", funcionario.Nome);
                    command.Parameters.AddWithValue("@cpf", funcionario.CPF);
                    command.Parameters.AddWithValue("@rg", funcionario.RG);
                    command.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                    command.Parameters.AddWithValue("@enderecoId", funcionario.EnderecoId);
                    command.Parameters.AddWithValue("@departamentoId", funcionario.DepartamentoId);
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

        internal bool DeletarFuncionario(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "DELETE FROM Funcionario WHERE Id = @id ";

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

        internal bool AtualizaFuncionario(Funcionario funcionario)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "UPDATE Funcionario SET Nome = @nome , CPF = @cpf , RG = @rg , Telefone = @telefone , EnderecoId = @enderecoId , DepartamentoId = @departamentoId  WHERE Id = @id";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@nome", funcionario.Nome);
                    command.Parameters.AddWithValue("@cpf", funcionario.CPF);
                    command.Parameters.AddWithValue("@rg", funcionario.RG);
                    command.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                    command.Parameters.AddWithValue("@enderecoId", funcionario.EnderecoId);
                    command.Parameters.AddWithValue("@departamentoId", funcionario.DepartamentoId);
                    command.Parameters.AddWithValue("@id", funcionario.Id);
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

        internal DataSet RetornaFuncionarios()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Nome , CPF , RG ,Telefone , EnderecoId , DepartamentoId from Funcionario Order by Nome";

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

        internal DataSet RetornaFuncionario(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Nome , CPF , RG ,Telefone , EnderecoId , DepartamentoId from Funcionario WHERE IdAluno = @id";

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

