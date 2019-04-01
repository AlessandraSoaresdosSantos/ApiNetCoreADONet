using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAdoNet 
{
    public interface IEndereco
    {
        DataSet RetornaEnderecos();

        bool DeletarEndereco(int id);

        bool InserirEndereco(WebApidonNet.ORM.Endereco endereco);

        bool AtualizarEndereco(WebApidonNet.ORM.Endereco endereco);

        DataSet RetornaEndereco(int id);
    }
}
