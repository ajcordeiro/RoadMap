﻿using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoadMap.Clientes.Validacoes
{
    public static class ValidacoesCliente
    {
        public static bool ValidarEmail(string email)
        {
            bool ok = true;

            if (string.IsNullOrEmpty(email))
            {
                Console.Write(" Email não pode ser vazio");
                ok = false;
            }
            else
            {
                ok = Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");

                if (!ok)
                    Console.Write(" Email digitado inválido");
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
                            break;
                        case ConsoleKey.Escape:
                            continuarLoop = false;
                            entrada = "ESC";
                            break;
                        case ConsoleKey.F12:
                            continuarLoop = false;
                            entrada = "F12";
                            break;
                        case ConsoleKey key when ((ConsoleKey.A <= key) && (key <= ConsoleKey.Z) ||
                                                  (ConsoleKey.Backspace <= key) && (key <= ConsoleKey.Spacebar)):

                            entrada += cki.KeyChar;

                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            return entrada;
        }

        public static string LerNumeros()
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
                            break;
                        case ConsoleKey.Escape:
                            continuarLoop = false;
                            entrada = "ESC";
                            break;
                        case ConsoleKey.F12:
                            continuarLoop = false;
                            entrada = "F12";
                            break;
                        case ConsoleKey key when ((ConsoleKey.D0 <= key) && (key <= ConsoleKey.D9) ||
                                                  (ConsoleKey.NumPad0 <= key) && (key <= ConsoleKey.NumPad9)):
                            entrada += cki.KeyChar;

                            if (entrada.Length < 12)
                            {
                                entrada.Append(cki.KeyChar);
                                Console.Write(cki.KeyChar);
                            }
                            else
                            {
                                entrada = entrada.Remove(entrada.Length - 1);
                            }
                            // Console.Write(cki.KeyChar);
                            break;
                    }
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
                Console.SetCursorPosition(7, 5);
                Console.Write("Inválido!");
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

        public static string LerCampos()
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
                            break;
                        case ConsoleKey.Escape:
                            continuarLoop = false;
                            entrada = "ESC";
                            break;
                        case ConsoleKey.F12:
                            continuarLoop = false;
                            entrada = "F12";
                            break;
                        case ConsoleKey key when ((ConsoleKey.A <= key) && (key <= ConsoleKey.Z) ||
                                                  (ConsoleKey.F <= key) && (ConsoleKey.F24 <= key) ||
                                                  (ConsoleKey.Backspace <= key) && (key <= ConsoleKey.Spacebar)) ||
                                                  ((ConsoleKey.D0 <= key) && (key <= ConsoleKey.D9) ||
                                                  (ConsoleKey.NumPad0 <= key) && (key <= ConsoleKey.NumPad9)):

                            
                            entrada += cki.KeyChar;

                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            return entrada;
        }

        public static string ValidaMenuSair()
        {
            ConsoleKeyInfo cki;
            bool continuarLoop = true;
            string entrada = string.Empty;
            entrada = entrada.ToUpper();

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
                            break;

                        case ConsoleKey key when ((ConsoleKey.S == key) || (ConsoleKey.N == key) ||
                                                  (ConsoleKey.Backspace <= key) && (key <= ConsoleKey.Spacebar)):

                            entrada += cki.KeyChar;

                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            return entrada;
        }

    }
}
