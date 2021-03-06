﻿namespace WebApidonNet.ORM
{
    /// <summary>
    /// DTO que trabalha com os dados da tabela Endereco
    /// </summary>

    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int FuncionarioId { get; set; }
    }
}
