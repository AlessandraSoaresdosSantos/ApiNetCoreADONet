using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApidonNet.ORM.Model;

namespace WebApiAdoNet
{
    public class Funcionario : IFuncionario
    {

        private readonly FuncionarioModel _enderecoModel;
        private readonly IConfiguration _configuration;

        public Funcionario(IConfiguration configuration)
        {
            _configuration = configuration;
            _enderecoModel = new FuncionarioModel(_configuration);
        }


        public DataSet RetornaFuncionarios()
        {
            DataSet funcionarios = _enderecoModel.RetornaFuncionarios();

            return funcionarios;
        }

        public bool DeletarFuncionario(int id)
        {
            return _enderecoModel.DeletarFuncionario(id);
        }

        public bool InserirFuncionario(WebApidonNet.ORM.Funcionario dto)
        {
            return _enderecoModel.InserirFuncionario(dto);
        }

        public bool AtualizarFuncionario(WebApidonNet.ORM.Funcionario dto)
        {
            return _enderecoModel.AtualizarFuncionario(dto);
        }

        public DataSet RetornaFuncionario(int id)
        {
            return _enderecoModel.RetornaFuncionario(id);
        }
    }
}
