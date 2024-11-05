using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("Post_English", TypeName = "LONGTEXT")]
        public string Post_English { get; set; }

        [Column("Post_Sinhala", TypeName = "LONGTEXT")]
        public string Post_Sinhala { get; set; }

        [Column("Post_Tamil", TypeName = "LONGTEXT")]
        public string Post_Tamil { get; set; }

        [MaxLength(100)]
        [Column("Cover_Image")]
        public string Cover_Image { get; set; }

        [MaxLength(100)]
        [Column("Image1")]
        public string Image1 { get; set; }

        [MaxLength(100)]
        [Column("Image2")]
        public string Image2 { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        public DateTime Publish_DateTime { get; set; }

        [Required]
        public string Type { get; set; } = "NORMAL";

        [Required]
        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Post_Comment> Comments { get; set; }
        public ICollection<Post_Like> Likes { get; set; }
    }
}