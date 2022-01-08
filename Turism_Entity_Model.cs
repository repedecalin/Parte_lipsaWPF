using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Turism_Model
{
    public partial class Turism_Entity_Model : DbContext
    {
        public Turism_Entity_Model()
            : base("name=Turism_Entity_Model")
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Guide> Guides { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Souvenir> Souvenirs { get; set; }
        public virtual DbSet<Tourist> Tourists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Souvenir>()
                .Property(e => e.price)
                .HasPrecision(5, 2);
        }
    }
}
