using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GamataAPI.Context
{
    [Table("t_sell")]
    public class Sell
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("Quantity")]
        public decimal Quantity { get; set; }

        [Required]
        [Column("Unit_Price")]
        public decimal Unit_Price { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("UOM")]
        public string UOM { get; set; }

        public DateTime? Available_DateTime { get; set; }

        public DateTime? Expired_DateTime { get; set; } = new DateTime(9999, 12, 31);

        [Required]
        [Column("FK_Product_Code")]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool IsActive { get; set; } = true;


        [Required]
        [Column("FK_Country_Code")]
        public string FK_Country_Code { get; set; }

        [Required]
        [Column("FK_Country_Type")]
        public string FK_Country_Type { get; set; }

        [Required]
        [Column("FK_Country_Parent")]
        public string FK_Country_Parent { get; set; }

        [ForeignKey("FK_Country_Code,FK_Country_Type,FK_Country_Parent")]
        public Country_Detail Country_Detail { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Remark { get; set; }

        [MaxLength(200)]
        public string Image01 { get; set; }

        [MaxLength(200)]
        public string Image02 { get; set; }

        [MaxLength(200)]
        public string Image03 { get; set; }

        [MaxLength(200)]
        public string Image04 { get; set; }

        public int Ref_PlantID { get; set; }

        [Required]
        public DateTime Inserted_DateTime { get; set; } = DateTime.Now;

        [Required]
        public DateTime Last_Updated_DateTime { get; set; } = DateTime.Now;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
        ///
        [NotMapped]
        public string Location_Description { get; set; }

        public ICollection<WishList> WishLists { get; set; }
        public ICollection<Sell_Rate> Ratings { get; set; }
        public ICollection<Inquiry> Inquries { get; set; }

        //new modification
        public ICollection<Temp_Shopping_Cart> Temp_Shopping_Cart { get; set; }
        public ICollection<Order_Detail> Order_Details { get; set; }
    }
}




