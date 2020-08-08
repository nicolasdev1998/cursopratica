using System;
using DotNetParaticaInterfaces;

namespace DotNetPratica
{
    public class JogadorA : IJogador
    {
        private readonly string _nome;
        public JogadorA(string nome = "Maradona")
        {
            _nome = nome;
        }

        public void Chutar()
        {
            Console.WriteLine($"{_nome} esta chutendo");
        }

        public void Correr()
        {
            Console.WriteLine($"{_nome} esta corriendo");
        }

        public void Passar()
        {
            Console.WriteLine($"{_nome} esta passeando");
        }
    }
}