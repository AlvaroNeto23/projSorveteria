using Sorveteria.Dominio;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Sorveteria.RepositorioEF
{
    public class Contexto : DbContext
    {
        public Contexto()
            : base("DBSorveteria")
        {
        }

        public DbSet<Carrinho> Carrinho { get; set; }
        public DbSet<CarrinhoEntradaSaida> CarrinhoEntradaSaida { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<ProdutoCompra> ProdutoCompra { get; set; }
        public DbSet<ProdutoVenda> ProdutoVenda { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Empresa>().Property(x => x.RazaoSocial).IsRequired().HasColumnType("varchar").HasMaxLength(70);
            modelBuilder.Entity<Empresa>().Property(x => x.CNPJ).IsRequired().HasColumnType("varchar").HasMaxLength(30);
        }
    }
}
