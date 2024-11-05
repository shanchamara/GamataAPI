using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GamataAPI.Context
{
    [Table("m_supplier_item")]
    public class Supplier_Item
    {

        [Key, Column("Code"), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Code { get; set; }

        /// <summary>
        ///  Supplier
        /// </summary>
        [Required]
        [Column("FK_Supplier_Code")]
        public int FK_Supplier_Code { get; set; }

        [ForeignKey("FK_Supplier_Code")]
        public Supplier Supplier { get; set; }

        /// <summary>
        /// Product
        /// </summary>
        [Column("FK_Product_Code")]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        [MaxLength(100)]
        [Column("Type")]
        public string Type { get; set; }

        [MaxLength(1000)]
        [Column("Name_Sinhala")]
        public string Name_Sinhala { get; set; }

        [Required]
        [MaxLength(1000)]
        [Column("Name_English")]
        public string Name_English { get; set; }

        [MaxLength(1000)]
        [Column("Name_Tamil")]
        public string Name_Tamil { get; set; }

        [MaxLength(5000)]
        [Column("Description", TypeName = "mediumtext")]
        public string Description { get; set; }


        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
       // public ICollection<Advisory> Advisories { get; set; }

        //[NotMapped]
        //public SelectList Suppliers { get; set; }

        //[NotMapped]
        //public SelectList Products { get; set; }
    }
}