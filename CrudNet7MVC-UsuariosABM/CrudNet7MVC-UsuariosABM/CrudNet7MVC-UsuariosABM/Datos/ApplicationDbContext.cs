using CrudNet7MVC_UsuariosABM.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC_UsuariosABM.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Agregar modelos acá
        public DbSet<Contacto> Contacto { get; set; }

    }
}