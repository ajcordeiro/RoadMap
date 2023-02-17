using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap
{
    public class Tela
    {
        public static void DrawScreen()
        {
            Console.Write("+");
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("-");
            }

            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 20; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 80; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            header();
        }

        private static void header()
        {
            Console.SetCursorPosition(70, 1);
            Console.Write(DateTime.Now.ToString("dd/MM/yyyy"));
            Console.SetCursorPosition(70, 2);
            Console.Write(DateTime.Now.ToString("H:mm"));

            Console.SetCursorPosition(2, 3);
            Console.WriteLine("ESC - Sair   F12 - Voltar");

            Console.SetCursorPosition(1, 4);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
        }
    }
}
