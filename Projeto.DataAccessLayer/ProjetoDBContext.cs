using Microsoft.EntityFrameworkCore;
using Projeto.DataAccessLayer.Entidades;
using Projeto.DataAccessLayer.Entidades.Pessoas;
using Projeto.DataAccessLayer.Entidades.Produtos;
using Projeto.DataAccessLayer.Faturacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DataAccessLayer
{
    public class ProjetoDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=ProjetoDB;Trusted_Connection=True;";
            options.UseSqlServer(connectionString);
        }


        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Cliente> Clientes { get; set; }
        
        DbSet<Fornecedor> Fornecedores { get; set; }
        DbSet<Loja> Lojas { get; set; }
        DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        DbSet<Produto> Produto { get; set; }
        DbSet<DetalheVenda> DetalheVendas { get; set; }
        DbSet<Estoque> Estoque { get; set; }
        DbSet<PontoDeVenda> PontoDeVendas { get; set; }
        DbSet<Venda> Vendas { get; set; }
    }
}
