using System;
using DotNetParaticaInterfaces;

namespace DotNetParaticaJogo
{
    public class JogoFoda
    {
        private readonly IJogador _jogador1;
        private readonly IJogador _jogador2;
        public JogoFoda(IJogador jogador1, IJogador jogador2)
        {
            _jogador1 = jogador1;
            _jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            _jogador1.Passar();
            _jogador1.Chutar();
            _jogador1.Correr();
            Console.WriteLine("PROXIMO ATLETA");
            _jogador2.Passar();
            _jogador2.Chutar();
            _jogador2.Correr();
        }            
    }
}