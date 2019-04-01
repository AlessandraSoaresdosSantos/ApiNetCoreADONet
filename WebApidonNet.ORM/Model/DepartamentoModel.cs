using Microsoft.Extensions.Configuration;
using System.Data;

namespace WebApidonNet.ORM
{
    public class DepartamentoModel
    {
        private readonly DepartamentoDAO _departamentoDAO;
        readonly IConfiguration _configuration;

        public DepartamentoModel(IConfiguration configuration)
        {
            _configuration = configuration;
            if (_departamentoDAO == null)
                _departamentoDAO = new DepartamentoDAO(_configuration);
        }

        public DataSet RetornaDepartamentos()
        {
            return _departamentoDAO.RetornaDepartamentos();
        }

        public bool DeletarDepartamento(int id)
        {
            return _departamentoDAO.DeletarDepartamento(id);
        }

        public bool AtualizarDepartamento(Departamento departamento)
        {
            return _departamentoDAO.AtualizaDepartamento(departamento);
        }

        public bool InserirDepartamento(Departamento dto)
        {
            return _departamentoDAO.InserirDepartamento(dto);
        }

        public DataSet RetornaDepartamento(int id)
        {
            return _departamentoDAO.RetornaDepartamento(id);
        }
    }
}
