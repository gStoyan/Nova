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
        public string Name { get; set; }

        [Column("Damage")]
        public int Damage { get; set; }

        [Column("Armor")]
        public int Armor { get; set; }

        [Column("Range")]
        public int Range { get; set; }

        [Column("Description")]
        [Required]
        public string Description { get; set; }

        public int NovaModelId { get; set; }

        public NovaModel NovaModel { get; set; }
    }
}
