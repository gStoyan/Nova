using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nova.Data.Models
{
    public class Army
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
        public List<Unit> Units { get; set; }

        public int NovaModelId { get; set; }
        public NovaModel NovaModel { get; set; }


    }
}
