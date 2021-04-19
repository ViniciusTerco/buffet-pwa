using System.Collections.Generic;
using Buffet.ViewModel.Shared;

namespace Buffet.ViewModel.Home
{
    public class StatusConvidadoViewModel
    {

        public List<Status> ListaDeStatus { get; set; }

        public StatusConvidadoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }
        
        
    }
}