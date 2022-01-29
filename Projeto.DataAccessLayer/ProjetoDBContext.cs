using Microsoft.EntityFrameworkCore;
using Projeto.DataAccessLayer.Entidades;
using Projeto.DataAccessLayer.Entidades.Pessoas;
using Projeto.DataAccessLayer.Entidades.Produtos;
using Projeto.DataAccessLayer.Faturacao;

namespace Projeto.DataAccessLayer
{
    public class ProjetoDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = @"Server=(LocalDB)\MSSQLLocalDB;Database=ProjetoDB;Trusted_Connection=True;";
            options.UseSqlServer(connectionString);
        }


        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<CategoriaProduto> CategoriaProdutos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<DetalheVenda> DetalheVendas { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<PontoDeVenda> PontoDeVendas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}
