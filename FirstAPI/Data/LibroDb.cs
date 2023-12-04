using FirstAPI.Modelos;
using Microsoft.EntityFrameworkCore;

namespace FirstAPI.Data
{
    public class LibroDb : DbContext
    {

        public LibroDb(DbContextOptions<LibroDb> options): base(options)
        {

        }


        public DbSet<Libro> Libros => Set<Libro>();
    }
}
