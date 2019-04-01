using Microsoft.Extensions.Configuration; 
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApidonNet.ORM.DAO;

namespace WebApidonNet.ORM.Model
{
    public class FuncionarioModel
    {
        private readonly FuncionarioDAO _funcionarioDAO;
        readonly IConfiguration _configuration;

        public FuncionarioModel(IConfiguration configuration)
        {
            _configuration = configuration;
            if (_funcionarioDAO == null)
                _funcionarioDAO = new FuncionarioDAO(_configuration);
        }

        public DataSet RetornaFuncionarios()
        {
            return _funcionarioDAO.RetornaFuncionarios();
        }

        public bool DeletarFuncionario(int id)
        {
            return _funcionarioDAO.DeletarFuncionario(id);
        }

        public bool AtualizarFuncionario(Funcionario departamento)
        {
            return _funcionarioDAO.AtualizaFuncionario(departamento);
        }

        public bool InserirFuncionario(Funcionario dto)
        {
            return _funcionarioDAO.InserirFuncionario(dto);
        }

        public DataSet RetornaFuncionario(int id)
        {
            return _funcionarioDAO.RetornaFuncionario(id);
        }
    }
}
