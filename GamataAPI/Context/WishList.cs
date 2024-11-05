using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_wishList")]
    public class WishList
    {
        [Required]
        [Key, Column("FK_Sell_Code", Order = 0)]
        public int FK_Sell_Code { get; set; }

        [ForeignKey("FK_Sell_Code")]
        public Sell Sell { get; set; }

        [Required]
        [Key, Column("FK_UserID", Order = 1)]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
