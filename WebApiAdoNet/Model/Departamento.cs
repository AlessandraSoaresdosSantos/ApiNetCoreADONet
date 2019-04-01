using Microsoft.Extensions.Configuration;
using System.Data;
using WebApidonNet.ORM;

namespace WebApiAdoNet
{
    public class Departamento : IDepartamento
    {
        private readonly DepartamentoModel _departamentoModel;
        private readonly IConfiguration _configuration;

        public Departamento(IConfiguration configuration)
        {
            _configuration = configuration;
            _departamentoModel = new DepartamentoModel(_configuration);
        }
         
        public DataSet RetornaDepartamentos()
        {
            DataSet departamentos = _departamentoModel.RetornaDepartamentos();

            return departamentos;
        }

        public bool DeletarDepartamento(int id)
        {
            return _departamentoModel.DeletarDepartamento(id);
        }

        public bool InserirDepartamento(WebApidonNet.ORM.Departamento dto)
        {
            return _departamentoModel.InserirDepartamento(dto);
        }

        public bool AtualizarDepartamento(WebApidonNet.ORM.Departamento dto)
        {
            return _departamentoModel.AtualizarDepartamento(dto);
        }

        public DataSet RetornaDepartamento(int id)
        {
            return _departamentoModel.RetornaDepartamento(id);
        }
    }
}
