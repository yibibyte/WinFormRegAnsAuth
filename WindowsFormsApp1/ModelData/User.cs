namespace WindowsFormsApp1.ModelData
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string FullName { get; set; }

        [StringLength(30)]
        public string Login { get; set; }

        [StringLength(30)]
        public string Password { get; set; }

        [StringLength(5)]
        public string Gender { get; set; }

        public int? Role { get; set; }
    }
}
