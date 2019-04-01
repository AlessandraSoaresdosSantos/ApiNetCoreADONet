using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiAdoNet 
{
    public interface IFuncionario
    {
        DataSet RetornaFuncionarios();

        bool DeletarFuncionario(int id);

        bool InserirFuncionario(WebApidonNet.ORM.Funcionario funcionario);

        bool AtualizarFuncionario(WebApidonNet.ORM.Funcionario funcionario);

        DataSet RetornaFuncionario(int id);
    }
}
