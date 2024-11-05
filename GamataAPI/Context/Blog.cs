using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_blog")]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        public string Category { get; set; }

        public string Short_Text { get; set; }

        [Required]
        public string Subject { get; set; }

        [Required]
        [Column("Body_English", TypeName = "LONGTEXT")]
        public string Body_English { get; set; }

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

        public string FK_User_ApprovedID { get; set; }



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




