using Microsoft.AspNet.Identity.EntityFramework;

namespace Mentira.Crud.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection")
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public System.Data.Entity.DbSet<Mentira.Crud.Models.TipoCliente> TipoClientes { get; set; }
        public System.Data.Entity.DbSet<Mentira.Crud.Models.Cliente> Clientes { get; set; }

    }
}