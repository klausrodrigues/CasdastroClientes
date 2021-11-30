using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cliente.API.Data;
using Cliente.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cliente.API.Controllers
{
    [ApiController]
    [Route("Api/[controller]")]

    public class ClienteController : ControllerBase
    {
       
        private readonly DataContext _context;
        public ClienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Cadastro> Get()
        {
            return _context.Clientes;
        }

        [HttpGet("{id}")]
        public Cadastro GetById(int id)
        {
            return _context.Clientes.FirstOrDefault(
                Cadastro => Cadastro.CadastroId == id
            );
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
