using System;
using System.Collections.Generic;
using System.Linq;
using Buffet.Data;

namespace Buffet.Models.Buffet.Cliente
{

    
    public class ClienteService
    {

        private readonly DataBaseContext _dataBaseContext;

        public ClienteService(DataBaseContext dataBaseContext)
        {
            _dataBaseContext = dataBaseContext;
        }
        
        public List<ClienteEntity> obterclietes()
        {
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
                return _dataBaseContext.Clientes.ToList();
        }
    }
}