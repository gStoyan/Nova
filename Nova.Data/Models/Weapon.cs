using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nova.Data.Models
{
    public class Weapon
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Column("Name")]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Column("Description")]
        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Column("Damage")]
        public int Damage { get; set; }
    }
}
