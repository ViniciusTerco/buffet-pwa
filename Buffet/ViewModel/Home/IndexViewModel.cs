using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using Buffet.Models.Buffet.Cliente;

namespace Buffet.ViewModel.Home
{
    public class IndexViewModel
    {
        public string InformacaoQualquer { get; set; }
        public string Titulo { get; set; }
        
        public Usuario usuarioLogado { get; set; }
        
        public ICollection<Cliente> Clientes { get; set; }

        public IndexViewModel()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Usuario
    {
        public string nome { get; set; }
        public int idade { get; set; }
        
    }

    public class Cliente
    {
        public string nome { get; set; }
        public string id { get; set; }
    }
    
}