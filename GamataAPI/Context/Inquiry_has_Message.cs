using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_inquiry_has_message")]
    public class Inquiry_has_Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_Inquiry")]
        public int FK_Inquiry { get; set; }

        [ForeignKey("FK_Inquiry")]
        public Inquiry Inquiry { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Message { get; set; }

        public bool IsDeleted { get; set; } = false;

        ///Additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;

        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        public bool IsView { get; set; } = false;
    }
}
