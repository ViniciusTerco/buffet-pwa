using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Buffet.Models;
using Buffet.Models.Buffet.Cliente;
using Buffet.ViewModel.Home;

namespace Buffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // 1° Forma de Mandar dados para view
            ViewBag.InformacaoQualquer = "Informação Qualquer Bag";
            
            // 2° Forma de mandar dados para view
            ViewData["informacao"] = "Infomacao Qualquer Data";
            
            //3° Forma de mandar dados para view
            var ViewModel = new IndexViewModel();
            ViewModel.InformacaoQualquer = "Infomação Qualquer";
            ViewModel.Titulo = "Titulo";
            
            return View(ViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
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