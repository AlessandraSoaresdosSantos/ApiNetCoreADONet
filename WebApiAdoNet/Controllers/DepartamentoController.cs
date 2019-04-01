using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebApiAdoNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IDepartamento _departamento;
        
        public DepartamentoController(IConfiguration configuration)
        {
            _configuration = configuration;
            _departamento = new Departamento(_configuration);
        }


        // GET: api/Departamento
        [HttpGet]
        public IActionResult Get()
        {
            DataSet departamentos = _departamento.RetornaDepartamentos();

            return Ok(departamentos);
        }

        // GET: api/Departamento/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            DataSet departamento = _departamento.RetornaDepartamento(id);

            return Ok(departamento);
        }

        // POST: api/Departamento
        [HttpPost]
        public IActionResult Post([FromBody] WebApidonNet.ORM.Departamento departamento)
        {
            return Ok(_departamento.InserirDepartamento(departamento));
        }

        // PUT: api/Departamento/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] WebApidonNet.ORM.Departamento departamento)
        {
            return Ok(_departamento.AtualizarDepartamento(departamento));
        }

        // DELETE: api/Departamento/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(_departamento.DeletarDepartamento(id));
        }
    }
}
