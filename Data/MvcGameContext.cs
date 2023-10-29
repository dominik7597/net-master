using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcGame.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcGame.Data
{
    public class MvcGameContext : IdentityDbContext
    {
        public MvcGameContext(DbContextOptions<MvcGameContext> options)
            : base(options)
        {
        }

        public DbSet<Game> Game { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public DbSet<Publisher> Publisher { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
