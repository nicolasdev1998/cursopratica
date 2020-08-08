using DotNetParaticaJogo;

namespace DotNetPratica
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new JogoFoda(new Jogador1("Nicolas"), new JogadorA());
            jogo.IniciarJogo();
        }
    }    
}
