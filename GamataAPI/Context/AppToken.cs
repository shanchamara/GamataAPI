using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_apptoken")]
    public class AppToken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser User { get; set; }

        [Required]
        [Column("Token")]
        public string Token { get; set; }

        [Required]
        [Column("Mobile_OS")]
        public string Mobile_OS { get; set; }

        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;

    }
}
