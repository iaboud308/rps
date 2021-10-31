using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;



namespace rps {
    class GameContext : DbContext {

        public DbSet<DataModel> GameData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseMySQL(Config.GetConnectionString());
        }

    }
}