using System;
using DotNetParaticaInterfaces;

namespace DotNetParaticaJogo
{
    public class Jogador1 : IJogador
    {
        private readonly string _nome;
        public Jogador1(string nome)
        {
            _nome = nome;
        }

        public void Passar()
        {
           Console.WriteLine($"{_nome} esta passando");
        }

        public void Chutar()
        {
           Console.WriteLine($"{_nome} esta chutando");
        }

        public void Correr()
        {
           Console.WriteLine($"{_nome} esta correndo");
        }

    }
}