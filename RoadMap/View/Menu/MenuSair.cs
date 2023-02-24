using System;
using RoadMap.Controller;
using RoadMap.MenuInicial;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;

namespace RoadMap.Menu
{
    public class MenuSair
    {
        public static void ExitMenu(string titulo)
        {
            string sair = string.Empty;

            do
            {
                Console.SetCursorPosition(2, 20);
                Console.Write("Deseja sair [S/N]? ");
                sair = ValidacoesCliente.ValidaMenuSair();
                sair = sair.ToUpper();
                

                switch (sair)
                {
                    case "S":
                        Console.SetCursorPosition(2, 21);
                        Console.Write("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    case "N":
                        Console.Clear();
                        if(titulo == "Menu Abertura")
                            MenuAbertura.WriteOptions();

                        if(titulo == "CONTROLE DE CLIENTE" || titulo == "PESQUISAR CLIENTE" || titulo == "Deletar Cliente")
                        MenuInicialCliente.WriteOptions();

                        if (titulo == "Cadastrar Cliente")
                            CadastrarCliente.WriteOptions();
                        break;
                }
            } while (string.IsNullOrEmpty(sair));
        }
    }
}
