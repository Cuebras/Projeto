using Projeto.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Projeto.Web.Controllers
{
    
    public class AtivoController : ApiController
    {
       
        public IHttpActionResult Get()
        {
            var model =  new List<Ativo> {
                new Ativo {Id= 1, NomeAtivo="Ativo 1",TipoAtivo="A", DescricaoAtivo="Descrição ativo 1", DataAquisicaoAtivo= new DateTime() },
                new Ativo {Id= 1, NomeAtivo="Ativo 2",TipoAtivo="B", DescricaoAtivo="Descrição ativo 2", DataAquisicaoAtivo= new DateTime() },
                new Ativo {Id= 1, NomeAtivo="Ativo 3",TipoAtivo="C", DescricaoAtivo="Descrição ativo 3", DataAquisicaoAtivo= new DateTime() },
                new Ativo {Id= 1, NomeAtivo="Ativo 4",TipoAtivo="D", DescricaoAtivo="Descrição ativo 4", DataAquisicaoAtivo= new DateTime() },
                new Ativo {Id= 1, NomeAtivo="Ativo 5",TipoAtivo="E", DescricaoAtivo="Descrição ativo 5", DataAquisicaoAtivo= new DateTime() },
                new Ativo {Id= 1, NomeAtivo="Ativo 6",TipoAtivo="F", DescricaoAtivo="Descrição ativo 6", DataAquisicaoAtivo= new DateTime() },
            };

            return Ok(model);
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}