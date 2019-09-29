using MinhaCelula.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaCelula.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
          : base("Conexao")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DatabaseContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Pessoa> Pessoas { get; set; }
        public virtual DbSet<Endereco> Enderecos { get; set; }
        public virtual DbSet<Frequencia> Frequencias { get; set; }

    }
}
