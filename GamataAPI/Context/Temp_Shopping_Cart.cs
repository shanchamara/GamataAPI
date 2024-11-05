using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_temp_shopping_cart")]
    public class Temp_Shopping_Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("Quantity")]
        public decimal Quantity { get; set; }

        /// <summary>
        /// Buyer
        /// </summary>
        [Required]
        [Column("FK_BuyerID")]
        public string FK_BuyerID { get; set; }

        [ForeignKey("FK_BuyerID")]
        public AppUser Buyer { get; set; }

        [Required]
        [Column("FK_Sell_Code")]
        public int FK_Sell_Code { get; set; }

        [ForeignKey("FK_Sell_Code")]
        public Sell Sell { get; set; }

        public DateTime InsertedOn { get; set; } = DateTime.Now;
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}





