using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Buffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffet.Models;
using Buffet.Models.Buffet;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModel.Home;
using Buffet.ViewModel.Shared;

namespace Buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataBaseContext _dataBaseContext;

        public HomeController(
            ILogger<HomeController> logger,
            DataBaseContext databaseContext
            )
        {
            _logger = logger;
            _dataBaseContext = databaseContext;
        }

        public IActionResult Index()
        {

            var nobocliente = new ClienteEntity
            {
                Nome = "José",
                DataDeNascimento = new DateTime(),
                idade = 40
            };

            _dataBaseContext.Clientes.Add(nobocliente);
            _dataBaseContext.SaveChanges();
            
            var todosClientes = _dataBaseContext.Clientes.ToList();

            foreach (ClienteEntity cliente in todosClientes)
            {
                Console.WriteLine(cliente.Nome);
            }
              /*
            // 1° Forma de Mandar dados para view
            ViewBag.InformacaoQualquer = "Informação Qualquer Bag";
            
            // 2° Forma de mandar dados para view
            ViewData["informacao"] = "Infomacao Qualquer Data";
            
            */
            //3° Forma de mandar dados para view
            var ViewModel = new IndexViewModel();
            ViewModel.InformacaoQualquer = "Infomação Qualquer";
            ViewModel.Titulo = "Titulo";

            ViewModel.usuarioLogado = new Usuario()
            {
              nome  = "Vinicius",
              idade    = 34
            };
            
            return View(ViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        public IActionResult StatusEvento()
        {
            //Acessando um service para ter lista
            var ListaStatusEventos = new List<StatusEvento>();
            ListaStatusEventos.Add(new StatusEvento(){Id = 1,Descricao = "Reservado"});
            ListaStatusEventos.Add(new StatusEvento(){Id = 2,Descricao = "Confirmado"});
            ListaStatusEventos.Add(new StatusEvento(){Id = 3,Descricao = "Realizado"});
            
            //Criando a view model
            var viewmodel = new StatusEventoViewModel();
            
            //Alimentado a lista de Satatus
            foreach (StatusEvento statusEvento in ListaStatusEventos)
            {
                viewmodel.ListaDeStatus.Add(new Status(){id = statusEvento.Id,Descricao = statusEvento.Descricao});
            }
          
            return View(viewmodel);
        }
        
        public IActionResult StatusConvidado()
        {
             //Acessando um service para ter lista
            var ListaStatusConvidado = new List<StatusConvidado>();
            ListaStatusConvidado.Add(new StatusConvidado(){ID = 1, Descricao = "A confirmar"});
            ListaStatusConvidado.Add(new StatusConvidado() {ID = 2, Descricao = "Confirmado"});

            //Criando a view model
            var viewmodel = new StatusConvidadoViewModel();
            
            //Alimentado a lista de Satatus
            foreach (StatusConvidado statusConvidado in ListaStatusConvidado)
            {
                viewmodel.ListaDeStatus.Add(new Status(){id = statusConvidado.ID,Descricao = statusConvidado.Descricao});
            }
            return View(viewmodel);
        }
        
        public IActionResult Clientes()
        {
            // Trazer lista de entidade clientes do serviço de clientes model
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.obterclietes();
            
            //Criar e popular a view model
            var viewModel = new ClientesViewModel();
            foreach (ClienteEntity clienteEntity in listaDeClientes)
            {
                viewModel.Clientes.Add(new Cliente
                {
                   Nome = clienteEntity.Nome,
                   DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString()
                });    
            }
            
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}