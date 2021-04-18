using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nova.Data.Models
{
    public class NovaModel
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Name")]
        [Required]
        public string Name { get; set; }

        [Column("AttackPoints")]
        public int AttackPoints { get; set; }

        [Column("ArmorPoints")]
        public int ArmorPoints { get; set; }

        [Column("HealethPoints")]
        public int HealethPoints { get; set; }

        public List<Army> Armies { get; set; }
    }
}
