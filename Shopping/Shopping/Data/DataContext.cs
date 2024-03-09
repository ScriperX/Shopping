using Microsoft.EntityFrameworkCore;
using Shopping.Data.Entities;

namespace Shopping.Data
{
    public class DataContext : DbContext //Esta clase es MUY IMPORTANTE ya que es la que nos va a permitir conectarnos a la base de datos 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) //El objeto option se lo paso al constructor de la clase padre con el constructor de la clase padre                
        {
            
        }

        public DbSet<Country> Countries { get; set; } //Mi base de datos va a tener una colección de países 


        //Todo lo que tenga que ver con modificaciones de la base de datos, es en el DataContext Class con un override
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique(); //Usamos la expresión lamda "c => c.Name"
        }
    }
}
