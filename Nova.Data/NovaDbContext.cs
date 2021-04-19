using Microsoft.EntityFrameworkCore;
using Nova.Data.Models;

namespace Nova.Data
{
    public class NovaDbContext : DbContext
    {
        private const string ConnectionString = "Server=.;Database=NovaDb;Integrated Security=True;Trusted_Connection=True;MultipleActiveResultSets=true";
        public NovaDbContext()
        {

        }
        public NovaDbContext(DbContextOptions<NovaDbContext> options)
               : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<NovaModel> NovaModels { get; set; }
        public DbSet<Weapon> Weapons { get; set; }     
        public DbSet<Unit> Units { get; set; }
        public DbSet<Army> Armies { get; set; }
        public DbSet<Text> Texts { get; set; }
        public DbSet<Option> Options { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConnectionString);
            base.OnConfiguring(options);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            base.OnModelCreating(builder);
            
            builder.Entity<User>().ToTable("Users");

            builder.Entity<Option>()
                .ToTable("Options")
                .HasOne(o => o.Text)
                .WithMany(t => t.Options)
                .HasForeignKey(o => o.TextId);

            builder.Entity<Army>()
                .ToTable("Armies")
                .HasMany(a => a.Units)
                .WithOne(a => a.Army)
                .HasForeignKey(a => a.ArmyId);

            builder.Entity<NovaModel>()
                .ToTable("NovaModels")
                .HasMany(a => a.Armies)
                .WithOne(a => a.NovaModel)
                .HasForeignKey(a => a.NovaModelId);

            builder.Entity<Text>()
                .HasOne(t => t.NovaModel)
                .WithMany(n => n.Texts)
                .HasForeignKey(n => n.NovaModelId);

            builder.Entity<NovaModel>()
                .HasMany(n => n.Weapons)
                .WithOne(t => t.NovaModel)
                .HasForeignKey(t => t.NovaModelId);
        }
    }
}
