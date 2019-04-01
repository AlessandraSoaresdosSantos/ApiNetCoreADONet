namespace WebApidonNet.ORM
{
    /// <summary>
    /// DTO que trabalha com os dados da tabela Funcionario
    /// </summary>

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Telefone { get; set; }
        public int EnderecoId { get; set; }
        public int DepartamentoId { get; set; }
    }
}
