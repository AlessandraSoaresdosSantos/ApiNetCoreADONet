using System.Collections.Generic;

namespace WebApidonNet.ORM
{
    /// <summary>
    /// DTO que trabalha com os dados da tabela Departamento
    /// </summary>
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int FuncionarioId { get; set; }
    }
}
