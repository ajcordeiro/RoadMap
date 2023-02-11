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
        ///TDD é o Desenvolvimento Orientado por Testes (Test Driven Development - Desenvolvimento Dirigido por Testes). 
        ///Isso mesmo! Desenvolvemos o nosso software baseado em testes que são 
        ///escritos antes do nosso código de produção!
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
            // Arrange - São realizados os preparativos para a ação e resultado a serem testados
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

            // Act - A ação a ser realizada é feita nessa parte, além do resultado ser obtido (ou não, caso seja um
            // método sem retorno).
            //bool clienteCadastrado = Cliente.CadastrarCliente(_cliente);

            // Assert - Verificações são feitas nessa etapa, se constituindo concretamente nos parâmetros de aprovação de
            // um teste unitário.
           // Assert.True(clienteCadastrado);
        }
    }
}
