using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using xGame.Domain.Entities;

namespace xGame.Infra.Persistence
{
    public class XGameContext : DbContext
    {
        public IDbSet<Player> Players { get; set; }

        public IDbSet<Type> Types { get; set; }
        public XGameContext() : base("Server=.\\sqlexpress;Database=xGame;Trusted_Connection=True;")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            base.OnModelCreating(modelBuilder);


        }


    }
}
