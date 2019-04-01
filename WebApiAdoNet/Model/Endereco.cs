using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApidonNet.ORM.Model;

namespace WebApiAdoNet 
{
    public class Endereco: IEndereco
    {

        private readonly EnderecoModel _enderecoModel;
        private readonly IConfiguration _configuration;

        public Endereco(IConfiguration configuration)
        {
            _configuration = configuration;
            _enderecoModel = new EnderecoModel(_configuration);
        }


        public DataSet RetornaEnderecos()
        {
            DataSet enderecos = _enderecoModel.RetornaEnderecos();

            return enderecos;
        }

        public bool DeletarEndereco(int id)
        {
            return _enderecoModel.DeletarEndereco(id);
        }

        public bool InserirEndereco(WebApidonNet.ORM.Endereco dto)
        {
            return _enderecoModel.InserirEndereco(dto);
        }

        public bool AtualizarEndereco(WebApidonNet.ORM.Endereco dto)
        {
            return _enderecoModel.AtualizarEndereco(dto);
        }

        public DataSet RetornaEndereco(int id)
        {
            return _enderecoModel.RetornaEndereco(id);
        }
    }
}
