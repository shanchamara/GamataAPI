using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_sell_rate")]
    public class Sell_Rate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_Sell_Code")]
        public int FK_Sell_Code { get; set; }

        [ForeignKey("FK_Sell_Code")]
        public Sell Sell { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        public int Rate { get; set; }

        [Column("Comment", TypeName = "LONGTEXT")]
        public string Comment { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
