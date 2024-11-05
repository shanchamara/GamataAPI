using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_library_has_group")]
    public class Library_has_Group
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        [Required]
        public string Name_English { get; set; }

        [Required]
        public string Name_Sinhala { get; set; }

        [Required]
        public string Name_Tamil { get; set; }

        public string Image { get; set; }

        public ICollection<Library_has_Post> Posts { get; set; }
    }
}
