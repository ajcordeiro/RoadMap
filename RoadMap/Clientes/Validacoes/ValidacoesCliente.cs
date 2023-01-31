using System;
using System.Text.RegularExpressions;

namespace RoadMap.Clientes.Validacoes
{
    public class ValidacoesCliente
    {
       public static bool ValidarEmail(string eMail)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(eMail))
            {
                Console.WriteLine("Email Vazio");
                ok = false;
            }
            else
            {
                ok = Regex.IsMatch(eMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (!ok)
                    Console.WriteLine("Email invalido");
            }
            return ok;
        }

        public static string LerLetras()
        {
            ConsoleKeyInfo cki;
            bool continuarLoop = true;
            string entrada = string.Empty;

            while (continuarLoop)
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.Backspace:
                            if (entrada.Length == 0)
                                continue;
                            entrada = entrada.Remove(entrada.Length - 1);
                            Console.Write("\b \b"); //Remove o último caractere digitado
                            break;
                        case ConsoleKey.Enter:
                            continuarLoop = false;
                            //entrada;
                            break;
                        case ConsoleKey key when ((ConsoleKey.A <= key) && (key <= ConsoleKey.W) ||
                                                  (ConsoleKey.Backspace <= key) && (key <= ConsoleKey.Spacebar)):
                            entrada += cki.KeyChar;
                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            return entrada;


        }

        public static string lerNumeros()
        {
            ConsoleKeyInfo cki;
            bool continuarLoop = true;
            string entrada = string.Empty;

            while (continuarLoop)
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.Backspace:
                            if (entrada.Length == 0)
                                continue;
                            entrada = entrada.Remove(entrada.Length - 1);
                            Console.Write("\b \b"); //Remove o último caractere digitado
                            break;
                        case ConsoleKey.Enter:
                            continuarLoop = false;
                            //entrada;
                            break;
                        case ConsoleKey key when ((ConsoleKey.D0 <= key) && (key <= ConsoleKey.D9) ||
                                                  (ConsoleKey.NumPad0 <= key) && (key <= ConsoleKey.NumPad9)):
                            entrada += cki.KeyChar;
                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            if (string.IsNullOrEmpty(entrada))
            {
                Console.WriteLine(" Campo não pode Ser Nullo !");
            }
            return entrada;
        }

        public static bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (string.IsNullOrEmpty(cpf))
            {
                return false;
            }
            else if (cpf.Length != 11)
            {
                Console.WriteLine(" CPF Inválido!");
                return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
