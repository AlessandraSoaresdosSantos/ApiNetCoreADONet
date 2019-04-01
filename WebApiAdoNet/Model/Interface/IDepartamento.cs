using System.Data;

namespace WebApiAdoNet
{
    public interface IDepartamento
    {
        DataSet RetornaDepartamentos();

        bool DeletarDepartamento(int id);

        bool InserirDepartamento(WebApidonNet.ORM.Departamento dto);

        bool AtualizarDepartamento(WebApidonNet.ORM.Departamento dto);

        DataSet RetornaDepartamento(int id);
    }
}
