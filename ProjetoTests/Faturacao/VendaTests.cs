using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projeto.Lib.Entidades.Produtos;
using System.Collections.Generic;

namespace Projeto.Lib.Faturacao.Tests
{
    [TestClass()]
    public class VendaTests
    {
        #region Testes que não usam o TestInitializer
        [TestMethod()]
        public void DeveImpedirVendaDeItemForaDoEstoqueTest()
        {
            //Arrange
            var estoque = new Estoque
            {
                ProdutosParaVenda = new List<Produto> {
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "SmartPhone XIAOMI" }
                }
            };

            var vendaParaOjoao = new Venda
            {
                DetalheVenda = new DetalheVenda { Produtos = new List<Produto>() }
            };

            vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "SmartPhone XIAOMI" });
            vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "SmartPhone XIAOMI" });

            var qtdDaInterface = 4;
            for (int i = 0; i < qtdDaInterface; i++)
            {
                vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "Computador" });
            }

            //Act
            var vendaPossivel = estoque.ValidarDisponibilidade(vendaParaOjoao.DetalheVenda.Produtos);

            //Assert
            Assert.IsFalse(vendaPossivel);
        }


        [TestMethod()]
        public void DevePermitirVendaDeItemNoEstoqueTest()
        {
            //Arrange
            var estoque = new Estoque
            {
                ProdutosParaVenda = new List<Produto> {
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "SmartPhone XIAOMI" },
                    new Produto { Nome = "SmartPhone XIAOMI" }
                }
            };

            var vendaParaOjoao = new Venda
            {
                DetalheVenda = new DetalheVenda { Produtos = new List<Produto>() }
            };

            vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "SmartPhone XIAOMI" });
            vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "SmartPhone XIAOMI" });

            var qtdDaInterface = 4;
            for (int i = 0; i < qtdDaInterface; i++)
            {
                vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = "Computador" });
            }

            //Act
            var vendaPossivel = estoque.ValidarDisponibilidade(vendaParaOjoao.DetalheVenda.Produtos);

            //Assert
            Assert.IsTrue(vendaPossivel);
        }

        #endregion Testes que não usam o TestInitializer

        #region Testes que usam o testInitialize
        private Estoque estoqueCentral;

        [TestInitialize]
        public void PrepararParaOsTestes()
        {
            estoqueCentral = new Estoque
            {
                ProdutosParaVenda = new List<Produto> {
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "Computador" },
                    new Produto { Nome = "SmartPhone XIAOMI" },
                    new Produto { Nome = "SmartPhone XIAOMI" },
                    new Produto { Nome = "Impressora HP" },
                    new Produto { Nome = "Impressora HP" },
                }
            };
        }


        [TestMethod]
        public void ExemploUsandoTesteInitializeImpedirVendaDeItemForaDoEstoqueTest()
        {
            var vendaParaOjoao = new Venda
            {
                DetalheVenda = new DetalheVenda
                {
                    Produtos = new List<Produto> {
                        new Produto { Nome = "SmartPhone XIAOMI" },
                        new Produto { Nome = "SmartPhone XIAOMI" },
                        new Produto { Nome = "SmartPhone XIAOMI" },
                }
                }
            };

            //Act
            var vendaPossivel = estoqueCentral.ValidarDisponibilidade(vendaParaOjoao.DetalheVenda.Produtos);

            //Assert
            Assert.IsFalse(vendaPossivel);
        }

        [DataTestMethod]
        [DataRow(-10, "SmartPhone XIAOMI", false)]
        [DataRow(0, "SmartPhone XIAOMI", false)]
        [DataRow(1, "SmartPhone XIAOMI", true)]
        [DataRow(2, "SmartPhone XIAOMI", true)]
        [DataRow(3, "SmartPhone XIAOMI", false)]
        [DataRow(30, "SmartPhone XIAOMI", false)]
        public void ExemploUsandoTesteInitializeValoresDinamicosTest(int quantidade, string nomeProduto, bool valorEsperado)
        {
            var vendaParaOjoao = new Venda
            {
                DetalheVenda = new DetalheVenda
                {
                    Produtos = new List<Produto>()
                }
            };
            for (int i = 0; i < quantidade; i++)
            {
                vendaParaOjoao.DetalheVenda.Produtos.Add(new Produto { Nome = nomeProduto });
            }

            //Act
            var vendaPossivel = estoqueCentral.ValidarDisponibilidade(vendaParaOjoao.DetalheVenda.Produtos);

            //Assert
            Assert.AreEqual(valorEsperado, vendaPossivel);
        }

        #endregion Testes que usam o testInitialize
    }
}