using RoadMap.Clientes.Validacoes;
using RoadMap.MenuInicial;
using System;

namespace RoadMap
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MenuAbertura.DrawScreen();
            MenuAbertura.WriteOptions();
        }
    }
}
