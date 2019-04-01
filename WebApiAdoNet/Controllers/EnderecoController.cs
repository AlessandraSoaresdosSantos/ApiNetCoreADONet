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
    public class EnderecoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IEndereco _endereco;

        public EnderecoController(IConfiguration configuration)
        {
            _configuration = configuration;
            _endereco = new Endereco(_configuration);
        }


        // GET: api/Endereco
        [HttpGet]
        public IActionResult Get()
        {
            DataSet enderecos = _endereco.RetornaEnderecos();

            return Ok(enderecos);
        }

        // GET: api/Endereco/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            DataSet endereco = _endereco.RetornaEndereco(id);

            return Ok(endereco);
        }

        // POST: api/Endereco
        [HttpPost]
        public IActionResult Post([FromBody] WebApidonNet.ORM.Endereco endereco)
        {
            return Ok(_endereco.InserirEndereco(endereco));
        }

        // PUT: api/Endereco/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WebApidonNet.ORM.Endereco endereco)
        {
            return Ok(_endereco.AtualizarEndereco(endereco));
        }

        // DELETE: api/Endereco/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_endereco.DeletarEndereco(id));
        }
    }
}
