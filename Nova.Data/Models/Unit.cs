using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nova.Data.Models
{
    public class Unit
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
        [Required]
        public int AttackPoints { get; set; }

        [Column("HealthPoints")]
        [Required]
        public int HealthPoints { get; set; }

        [Column("Range")]
        [Required]
        public int Range { get; set; }

        public string Description { get; set; }
        public int ArmyId { get; set; }
        public Army Army { get; set; }


    }
}
