using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Projeto.Lib.Entidades.Pessoas.Tests
{
    [TestClass()]
    public class PessoaTests
    {
        [TestMethod()]
        public void DeveCriarClienteTest()
        {
            //Arrange
            var pessoa = new Cliente();
            pessoa.Morada.Endereco = "Rua das Casas";
            pessoa.Morada.Complemento = "Falar com vizinha";
            pessoa.Morada.CodigoPostal = "2830";
            pessoa.Morada.Localidade = "Cidade";
            pessoa.NumeroFiscal = "123456789";
            pessoa.Telefone = "999999999";
            pessoa.DataNascimento = new DateTime(1999, 01, 01);
            
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