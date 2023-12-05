using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Pass;

namespace Konyvtar_Api.Context
{
    public class KonyvtarApi2023Context : DbContext
    {
        public KonyvtarApi2023Context(DbContextOptions options)
            :base(options)
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Book> book { get; set; }
        public virtual DbSet<Out> outs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("People List");
                entity.Property(e => e.ID).HasColumnName("identity");
                entity.HasKey(e => e.ID);
            });
            modelBuilder.Entity<Book>(entity =>
            {
                entity.ToTable("Book List");
                entity.Property(e => e.Id).HasColumnName("identity");
                entity.HasKey(e => e.Id);
            });
            modelBuilder.Entity<Out>(entity =>
            {
                entity.ToTable("Out List");
                entity.Property(e => e.ID).HasColumnName("identity");
                entity.HasKey(e => e.ID);
            }
                );
        }
    }
}
