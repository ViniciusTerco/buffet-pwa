using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;
using Microsoft.EntityFrameworkCore;

namespace Buffet.Models.Buffet.Cliente
{

    
    public class ClienteService
    {

        private readonly DataBaseContext _dataBaseContext;

        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        
        public void obterclietes()
        {
            //Obter um unico objeto.
            //var primeiroClienteOuNulo = _dataBaseContext.Clientes.FirstOrDefault();
            /*
            var clienteEspecifico1 = _dataBaseContext.
                Clientes.Single(c => c.Id.ToString().Equals("1"));
            var clienteEspecifico2 = _dataBaseContext.
                Clientes.Single(c => c.Nome.Contains("Jo"));
            var clienteEspecifico3 = _dataBaseContext.
                Clientes.Find("1");
            
            if (clienteEspecifico != null)
            {
            Console.WriteLine(clienteEspecifico.Id);
            Console.WriteLine(clienteEspecifico.Nome);
            Console.WriteLine(clienteEspecifico.Email);
            }
            */
            
            /*
            //Obter multiplos resultados
            var clientes = _dataBaseContext.
                Clientes.Where
                    (c => c.Nome.StartsWith("Jo") && c.Nome.EndsWith("e")
                ).ToList();
            */
            
            /*
            //Ordenação
            var clientes = _dataBaseContext.
                Clientes.OrderBy(c => c.Nome).ToList();
            
            */
            //Entidades Relacionadas
            var cliente = _dataBaseContext.
                Clientes
                .Include(c => c.Eventos).ToList()
                .Single(c => c.Id.ToString()
                    .Equals("1")
                );
            
           if (cliente != null)
            {
                Console.WriteLine(cliente.Id);
                Console.WriteLine(cliente.Nome);
                Console.WriteLine(cliente.Email);
                Console.WriteLine(cliente.Eventos.Count);
            }
            
            /*
            var listaClientes = new List<ClienteEntity>();
            listaClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Vinicius",
                DataDeNascimento = new DateTime(year:1986,month:10,day:23)
            });
            
            listaClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "José",
                DataDeNascimento = new DateTime(year:1980,month:12,day:20)
            });
            */
            
            //   return _dataBaseContext.Clientes.ToList();
        }
    }
}