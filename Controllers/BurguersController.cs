using System;
using Microsoft.AspNetCore.Mvc;
using teste_hamburgueria_mysql_azure.db;
using System.Collections.Generic;
using teste_hamburgueria_mysql_azure.Models;

namespace teste_hamburgueria_mysql_azure.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BurguersController : ControllerBase
    {
        // Propriedade privada que conterá o contexto
        private hamburgueriaContext _db { get; set; }
        public BurguersController(hamburgueriaContext contexto)
        {
            // Construtor recebe o contexto da injeção de dependência
            // e disponibiliza via propriedade
            _db = contexto;
        }

        [HttpGet]
        public List<BurguerModel> Get()
        {
            // Usa o contexto da classe
            var todosOsBurguers = _db.Burguer;
            
            var retorno = new List<BurguerModel>();
            foreach(var b in todosOsBurguers)
            {
                retorno.Add(new BurguerModel
                {
                    Nome = b.Nome,
                    Preco = b.Preco,
                });
            }

            return retorno;
        }
    }
}