using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Angular_Core.Data.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Int32 Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string Email { get; set; }

        public DateTime Createdon { get; set; }

        public int? Age { get; set; }

        public int? Gender { get; set; }
    }
}
