using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_order_detail")]
    public class Order_Detail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }


        [Required]
        [Column("FK_HeaderID")]
        public int FK_HeaderID { get; set; }

        [ForeignKey("FK_HeaderID")]
        public Order_Header Header { get; set; }


        [Required]
        [Column("FK_Sell_Code")]
        public int FK_Sell_Code { get; set; }

        [ForeignKey("FK_Sell_Code")]
        public Sell Sell { get; set; }

        [Required]
        [Column("Quantity")]
        public decimal Quantity { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("UOM")]
        public string UOM { get; set; }

        [Required]
        [Column("Unit_Price")]
        public decimal Unit_Price { get; set; }


        public DateTime InsertedOn { get; set; } = DateTime.Now;
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}

