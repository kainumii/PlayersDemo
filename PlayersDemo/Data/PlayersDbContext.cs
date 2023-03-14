using Microsoft.EntityFrameworkCore;
using PlayersDemo.Data.Models;

namespace PlayersDemo.Data
{
    public class PlayersDbContext : DbContext    
    {
        public PlayersDbContext(DbContextOptions<PlayersDbContext> options) : base(options)
        {

        }
        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Citizenship> Citizenships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Citizenship>().HasData(
                new Citizenship { Id = 1, Name = "Suomi" }, 
                new Citizenship { Id = 2, Name = "Ruotsi" }, 
                new Citizenship { Id = 3, Name = "Kanada" }
                );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Kärpät" }, 
                new Team { Id = 2, Name = "Ässät" }, 
                new Team { Id = 3, Name = "HIFK" });

            modelBuilder.Entity<Player>().HasData(
                new Player { Id = 1, LastName = "Anttila", FirstName = "Marko", IsRight = true, TeamId = 1, CitizenshipId = 1 },
                new Player { Id = 2, LastName = "Pakarinen", FirstName = "Iiro", TeamId = 3, CitizenshipId = 1 },
                new Player { Id = 3, LastName = "Ohtamaa", FirstName = "Atte", TeamId = 1, CitizenshipId = 1 },
                new Player { Id = 4, LastName = "Kunyk", FirstName = "Cody", TeamId = 1, CitizenshipId = 3 },
                new Player { Id = 5, LastName = "Tieksola", FirstName = "Tuukka", TeamId = 1, CitizenshipId = 1 },
                new Player { Id = 6, LastName = "Vesalainen", FirstName = "Kristian", TeamId = 3, IsRight = true, CitizenshipId = 1 },
                new Player { Id = 7, LastName = "Rundblad", FirstName = "David", TeamId = 1, CitizenshipId = 2 },
                new Player { Id = 8, LastName = "Rubin", FirstName = "Niklas", TeamId = 2 , CitizenshipId = 2 },
                new Player { Id = 9, LastName = "Paaso", FirstName = "Arttu", TeamId = 1, IsRight = true, Position = Position.Defender, CitizenshipId = 1});

        }
    }
}
