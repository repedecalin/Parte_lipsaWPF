namespace Turism_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Souvenir
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Souvenir()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int id_souvenir { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public decimal price { get; set; }

        public int available_quanity { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
