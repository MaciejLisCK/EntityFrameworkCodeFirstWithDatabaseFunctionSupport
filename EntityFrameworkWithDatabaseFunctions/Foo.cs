namespace EntityFrameworkWithDatabaseFunctions
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Foo")]
    public partial class Foo
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
