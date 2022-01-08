namespace Turism_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [Key]
        public int id_order { get; set; }

        public int id_souvenir { get; set; }

        public int id_tourist { get; set; }

        public int quantity { get; set; }

        public virtual Souvenir Souvenir { get; set; }

        public virtual Tourist Tourist { get; set; }
    }
}
