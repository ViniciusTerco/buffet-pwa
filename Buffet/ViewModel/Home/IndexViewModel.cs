using System.Runtime.Intrinsics.X86;

namespace Buffet.ViewModel.Home
{
    public class IndexViewModel
    {
        public string InformacaoQualquer { get; set; }
        public string Titulo { get; set; }
        
        public Usuario usuarioLogado { get; set; }
    }

    public class Usuario
    {
        public string nome { get; set; }
        public int idade { get; set; }
        
    }
    
}