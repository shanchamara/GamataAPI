using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_notification")]
    public class Notification
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Message { get; set; }


        [Column(TypeName = "mediumtext")]
        public string Message_Sinhala { get; set; }


        [Column(TypeName = "mediumtext")]
        public string Message_Tamil { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;

        [Required]
        public bool IsView { get; set; } = false;

        public string Type { get; set; } // COMMENT / BLOG/ POST/ INQUIRY

        public string TypeCode { get; set; }

        [Required]
        [Column("FK_To_UserID")]
        public int FK_To_UserID { get; set; }

        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
    }
}
