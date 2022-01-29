using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.DataAccessLayer.Entidades.Pessoas;
using System;

namespace Projeto.Tests.Entidades.Pessoas
{
    [TestClass()]
    public class PessoaTests
    {
        [TestMethod()]
        public void DeveCriarClienteTest()
        {
            //Arrange
            var pessoa = new Cliente
            {
                Endereco = "Rua das Casas",
                Complemento = "Falar com vizinha",
                CodigoPostal = "2830",
                Localidade = "Cidade",
                NumeroFiscal = "123456789",
                Telefone = "999999999",
                DataNascimento = new DateTime(1999, 01, 01)
            };

            //Act
            var possuiIdentificadorAtribuido = pessoa.Identificador != new Guid();
            var possuiDataAlteracaoAtribuida = pessoa.DataAlteracao != new DateTime();

            //Assert
            Assert.IsNotNull(pessoa);
            Assert.IsInstanceOfType(pessoa, typeof(Pessoa));
            Assert.IsTrue(pessoa.Ativo);
            Assert.IsTrue(possuiIdentificadorAtribuido);
            Assert.IsTrue(possuiDataAlteracaoAtribuida);
        }
    }
}