using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApidonNet.ORM.DAO;

namespace WebApidonNet.ORM.Model
{
    public class EnderecoModel
    {
        private readonly EnderecoDAO _enderecoDAO;
        readonly IConfiguration _configuration;

        public EnderecoModel(IConfiguration configuration)
        {
            _configuration = configuration;
            if (_enderecoDAO == null)
                _enderecoDAO = new EnderecoDAO(_configuration);
        }

        public DataSet RetornaEnderecos()
        {
            return _enderecoDAO.RetornaEnderecos();
        }

        public bool DeletarEndereco(int id)
        {
            return _enderecoDAO.DeletarEndereco(id);
        }

        public bool AtualizarEndereco(Endereco departamento)
        {
            return _enderecoDAO.AtualizaEndereco(departamento);
        }

        public bool InserirEndereco(Endereco dto)
        {
            return _enderecoDAO.InserirEndereco(dto);
        }

        public DataSet RetornaEndereco(int id)
        {
            return _enderecoDAO.RetornaEndereco(id);
        }
    }
}
