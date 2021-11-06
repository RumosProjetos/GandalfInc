using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Lib.Entidades.Pessoas;
using System;

namespace Projeto.Lib.Repositorios.Tests
{
    [TestClass()]
    public class RepositorioEntidadeTests
    {
        [TestMethod()]
        public void DeveCriarEntidadeTest()
        {
            //arrange
            var repo = new RepositorioEntidade();
            var cliente = new Cliente();
            var loja = new Loja();

            //act
            repo.Criar(cliente);
            repo.Criar(loja);
            var quantidade = repo.ListarTodos().Count;

            //assert
            Assert.AreEqual(2, quantidade);
        }


        [TestMethod()]
        public void DeveObterPorIdentificadorEntidadeTest()
        {
            //arrange
            var repo = new RepositorioEntidade();
            var identificadorCliente = new Guid("e62e756c-78b3-4556-9dfb-5911ef90e55d");
            var cliente = new Cliente { Identificador = identificadorCliente, Nome = "Pessoa Procurada" };
            var loja = new Loja { Identificador = new Guid("f66e383f-3422-4b33-bf2f-1dddc607d30d") };
            var cliente2 = new Cliente { Identificador = new Guid("3461c48b-afff-4864-9fb6-5d002ae6d43a"), Nome = "Pessoa Esquecida" };

            //act
            repo.Criar(cliente);
            repo.Criar(loja);
            repo.Criar(cliente2);
            var obtido = repo.ObterPorIdentificador(identificadorCliente);

            //assert
            Assert.IsInstanceOfType(obtido, typeof(Cliente));
            Assert.AreEqual("Pessoa Procurada", obtido.Nome);
        }

        [DataTestMethod]
        [DataRow("Joao", true)]
        [DataRow("Loja de Lisboa", true)]
        public void DeveObterPorNomeEntidadeTest(string nome, bool parametroExemplo)
        {
            //Arrange
            var repo = new RepositorioEntidade();
            var cliente = new Cliente { Nome = nome, Ativo = true };

            //Act
            repo.Criar(cliente);
            repo.ObterPorNome(nome);

            //Assert
            Assert.AreEqual(parametroExemplo, cliente.Ativo);
            Assert.AreEqual(nome, repo.ObterPorNome(nome).Nome);
        }
    }
}