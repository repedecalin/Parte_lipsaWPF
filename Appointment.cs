namespace Turism_Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        [Key]
        public int id_app { get; set; }

        public int id_route { get; set; }

        public int id_tourist { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public TimeSpan hour { get; set; }

        public virtual Route Route { get; set; }

        public virtual Tourist Tourist { get; set; }
    }
}
