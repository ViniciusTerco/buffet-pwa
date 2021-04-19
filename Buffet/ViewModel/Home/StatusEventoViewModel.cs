using System.Collections.Generic;
using Buffet.ViewModel.Shared;

namespace Buffet.ViewModel.Home
{
    public class StatusEventoViewModel
    {
        public List<Status> ListaDeStatus { get; set; }

        public StatusEventoViewModel()
        {
            ListaDeStatus = new List<Status>();
        }

    }
}