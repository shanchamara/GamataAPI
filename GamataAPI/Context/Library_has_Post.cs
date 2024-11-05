using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_library_has_post")]
    public class Library_has_Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Column("FK_Library_Group")]
        public int FK_Library_Group { get; set; }

        [ForeignKey("FK_Library_Group")]
        public Library_has_Group Library_Group { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        [Column("Content", TypeName = "LONGTEXT")]
        public string Content { get; set; }

        [Required]
        [Column("Lan")]
        public string Lan { get; set; } = "EN";

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        public bool IsApproved { get; set; } = false;

        public int FK_User_ApprovedID { get; set; }

        public DateTime PublishedOn { get; set; }

        public string Image { get; set; }

        [Required]
        public bool IsDeleted { get; set; } = false;

        //additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime? LastModifiedOn { get; set; } = DateTime.Now;
        public int? LastModifiedBy { get; set; }
    }
}
