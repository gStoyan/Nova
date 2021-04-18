using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nova.Data.Models
{
    public class Text
    {
        [Column("Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }

        [Column("Title")]
        [Required]
        public string Title { get; set; }

        [Column("Content")]
        [Required]
        public string Content { get; set; }
        [Column("Option")]
        public string Option { get; set; }
    }
}
