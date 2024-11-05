using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GamataAPI.Context
{
    [Table("m_product")]
    public class Product
    {
        [Key]
        [MaxLength(100)]
        public string Code { get; set; }

        [MaxLength(100)]
        [Column("Parent")]
        public string Parent { get; set; }

        [MaxLength(100)]
        [Column("Name_Sinhala")]
        public string Name_Sinhala { get; set; }

        [Required]
        [MaxLength(100)]
        [Column("Name_English")]
        public string Name_English { get; set; }

        [MaxLength(100)]
        [Column("Name_Tamil")]
        public string Name_Tamil { get; set; }

        [MaxLength(100)]
        [Column("Image")]
        public string Image { get; set; }


        [Column("Product_Description", TypeName = "mediumtext")]
        public string Product_Description { get; set; }

        [MaxLength(50)]
        [Column("UOMGroups")]
        public string UOMGroups { get; set; }

        [Column("IsSeed")]
        public bool IsSeed { get; set; } = false;

        public string Type { get; set; }

        public bool Is_SLGAP_Certified { get; set; } = false;

        ///additonal
        //[Required]
        //public DateTime InsertedOn { get; set; } = DateTime.Now;
        //[Required]
        //public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        //public int LastModifiedBy { get; set; }

        ///relations
        public ICollection<Supplier_Item> Supplier_Items { get; set; }
        public ICollection<Farming_Product> Farming_Products { get; set; }
        public ICollection<Plan> Plans { get; set; }
        public ICollection<Advisory> Advisories { get; set; }
        public ICollection<Harvest_Calendar> Harvest_Calendars { get; set; }
        public ICollection<Product_Instruction> Product_Instructions { get; set; }
        public ICollection<Crop_Record_Book> Crop_Record_Books { get; set; }

        //[NotMapped]
        //public SelectList ParentProducts { get; set; }

        //[NotMapped]
        //public HttpPostedFileBase ImageUpload1 { get; set; }
    }
}