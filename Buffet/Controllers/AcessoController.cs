using System;
using Buffet.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace Buffet.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ClienteService _clienteService;
        
        public AcessoController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        
        public IActionResult Login()
        {
            //_clienteService.obterclietes();
            return View();
        }
        
        public IActionResult RecuperarConta()
        {
            return View();
        }
        
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}