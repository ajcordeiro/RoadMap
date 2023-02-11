using Moq;
using RoadMap.Clientes;
using RoadMap.Clientes.Model;
using System;
using Xunit;

namespace WebTest
{
    public class FunctionTest
    {
        ///<summary>
        ///TDD � o Desenvolvimento Orientado por Testes (Test Driven Development - Desenvolvimento Dirigido por Testes). 
        ///Isso mesmo! Desenvolvemos o nosso software baseado em testes que s�o 
        ///escritos antes do nosso c�digo de produ��o!
        ///</sumary>

        //propriedades


        //Campo
        private Cliente _cliente;
        private Function _function;

        public FunctionTest()
        {
            var mock = new Mock<IClienteTeste>();

            mock.Setup(x => x.CadastrarCliente()).Returns(true);

            _cliente = new Cliente();
            _function = new Function();
        }
        

        [Fact]
        public void ValidaCadastroDoCliente()
        {
            // Arrange - S�o realizados os preparativos para a a��o e resultado a serem testados
            _cliente.Nome = "Pedro";
            _cliente.Cpf = "16516445835";
            _cliente.Telefone = "11954359055";
            _cliente.Email = "pedro@gmail.com";
            _cliente.Endereco = "Rua Teste 46";
            _cliente.Complemento = "";
            _cliente.Bairro = "Vila Uniao";
            _cliente.Cep = "03531232";
            _cliente.Cidade = "Sao Pedro";
            _cliente.DataCadastro = DateTime.Now;

            _function.CadastrarCliente();

            // Act - A a��o a ser realizada � feita nessa parte, al�m do resultado ser obtido (ou n�o, caso seja um
            // m�todo sem retorno).
            //bool clienteCadastrado = Cliente.CadastrarCliente(_cliente);

            // Assert - Verifica��es s�o feitas nessa etapa, se constituindo concretamente nos par�metros de aprova��o de
            // um teste unit�rio.
           // Assert.True(clienteCadastrado);
        }
    }
}
