using System;

namespace RoadMap.View
{
    public class BuscarCliente
    {  
        public static void ResultadoBuscarCliente(string cpf, string nome, DateTime dataCadastro, string email, string telefone, string celular, string endereco,
            string numero, string complemento, string cep, string bairro, string cidade  )
        {
            string FormatarCpf(string Cpf) => cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9, 2);
            string FormataCelular(string Celular) => "(" + celular.Substring(0, 2) + ")" + celular.Substring(2, 5) + "-" + celular.Substring(7, 4);
            string FormataCep(string Cep) => cep.Substring(0, 5) + "-" + cep.Substring(5, 3);
            
            string FormataTelefone(string Telefone) => "(" + telefone.Substring(0, 2) + ")" + telefone.Substring(2, 4) + "-" + telefone.Substring(6, 4);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Resultado da pesquisa:");

            Console.SetCursorPosition(2, 8);
            Console.Write($"CPF: {FormatarCpf(cpf)} - Data do Cadastro: {dataCadastro}");
            Console.SetCursorPosition(2, 9);
            Console.Write($"Cliente: {nome.ToUpper()}");
            Console.SetCursorPosition(2, 10);
            Console.Write($"Email: {email.ToUpper()}");
            Console.SetCursorPosition(2, 11);
            Console.Write($"Telefone: {FormataTelefone(telefone)} - Celular: {FormataCelular(celular)}");
            Console.SetCursorPosition(2, 12);
            Console.Write($"Endereço: {endereco.ToUpper()} -  Nº: {numero} - Complemento: {complemento.ToUpper()}");
            Console.SetCursorPosition(2, 13);
            Console.Write($"Cep: {FormataCep(cep)} - Bairro: {bairro.ToUpper()} - Cidade: {cidade.ToUpper()}");
            Console.SetCursorPosition(2, 15);
            Console.Write("------------------------------------------------------");
            Console.SetCursorPosition(2, 20);
            Console.Write("Pressione qualquer tecla para prosseguir.");
            Console.ReadKey();
        }
    }
}
