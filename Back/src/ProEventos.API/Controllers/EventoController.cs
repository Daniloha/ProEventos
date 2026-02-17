
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        {
        }

        public IEnumerable<Evento> _evento = new Evento[]
        {
            new Evento()
            {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                Local = "Rio de Janeiro",
                Lote = "1o Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2),
                ImagemURL = "foto1.png"
            }
            ,
            new Evento()
            {
                EventoId = 2,
                Tema = "Angular 11 e .NET 5",
                Local = "São Paulo",
                Lote = "2o Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(3),
                ImagemURL = "foto2.png"
            }

        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
            return _evento.FirstOrDefault(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo de Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id {id}";
        }

    }
}
