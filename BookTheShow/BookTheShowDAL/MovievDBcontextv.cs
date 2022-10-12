using BookTheShowEntity;
using Microsoft.EntityFrameworkCore;
using System;


namespace BookTheShowDAL
{
    public class MovieDBcontextv:DbContext
    {
        public DbSet<Moviev> moviesv { get; set; }
        public DbSet<Theatrev> theatresv { get; set; }
        public DbSet<ShowTimev> showtimingsv { get; set; }

        public MovieDBcontextv(DbContextOptions<MovieDBcontextv> options) : base(options)
        {



        }



        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2151;Initial Catalog=Book12;Integrated Security=True;");
        }
    }
}
