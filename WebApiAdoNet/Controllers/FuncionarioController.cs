using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApiAdoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IFuncionario _funcionario;

        public FuncionarioController(IConfiguration configuration)
        {
            _configuration = configuration;
            _funcionario = new Funcionario(_configuration);
        }


        // GET: api/Funcionario
        [HttpGet]
        public IActionResult Get()
        {
            DataSet funcionarios = _funcionario.RetornaFuncionarios();

            return Ok(funcionarios);
        }

        // GET: api/Funcionario/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            DataSet funcionario = _funcionario.RetornaFuncionario(id);

            return Ok(funcionario);
        }

        // POST: api/Funcionario
        [HttpPost]
        public IActionResult Post([FromBody] WebApidonNet.ORM.Funcionario funcionario)
        {
            return Ok(_funcionario.InserirFuncionario(funcionario));
        }

        // PUT: api/Funcionario/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WebApidonNet.ORM.Funcionario funcionario)
        {
            return Ok(_funcionario.AtualizarFuncionario(funcionario));
        }

        // DELETE: api/Funcionario/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_funcionario.DeletarFuncionario(id));
        }
    }
}
