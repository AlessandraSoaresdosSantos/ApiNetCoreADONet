using Microsoft.Extensions.Configuration;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApidonNet.ORM
{
    internal class DepartamentoDAO
    {
       private readonly string _connectionString;


        public DepartamentoDAO(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");

        }

        internal bool InserirDepartamento(Departamento dto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "INSERT INTO Departamento values(@nome, @funcionarioId);";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@nome", dto.Nome);
                    command.Parameters.AddWithValue("@funcionarioId", dto.FuncionarioId);
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

        internal bool DeletarDepartamento(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "DELETE FROM Departamento WHERE Id = @id ";

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

        internal bool AtualizaDepartamento(Departamento dto)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "UPDATE Departamento SET Nome  = @nome, FuncionarioId = @funcionarioId WHERE Id = @id";

                    SqlCommand command = new SqlCommand(sql, conn)
                    {
                        CommandType = CommandType.Text
                    };

                    command.Parameters.AddWithValue("@nome", dto.Nome);
                    command.Parameters.AddWithValue("@funcionarioId", dto.FuncionarioId);
                    command.Parameters.AddWithValue("@id", dto.Id);
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

        internal DataSet RetornaDepartamentos()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Id, Nome, FuncionarioId FROM Departamento Order by Nome";

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

        internal DataSet RetornaDepartamento(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                try
                {
                    conn.Open();
                    var sql = "SELECT Id, Nome, FuncionarioId FROM Departamento WHERE IdAluno = @id";

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

