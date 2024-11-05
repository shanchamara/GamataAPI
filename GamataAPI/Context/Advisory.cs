using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_advisory")]
    public class Advisory
    {

        [Key, Column("FK_Product_Code", Order = 0)]
        //[Index(IsClustered = true, IsUnique = false)]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Products { get; set; }

        [Key, Column("FK_Activity_Code", Order = 1)]
        public string FK_Activity_Code { get; set; }

        [ForeignKey("FK_Activity_Code")]
        public Activity Activities { get; set; }

        [DefaultValue(0)]
        [Column("Start_Duration")]
        //[Index(IsClustered = true, IsUnique = false)]
        public int Start_Duration { get; set; }

        [DefaultValue(0)]
        [Column("End_Duration")]
        public int End_Duration { get; set; }

        [Column("Zone")]
        public string Zone { get; set; }

        [Required]
        [Column("Description_English", TypeName = "LONGTEXT")]
        public string Description { get; set; }

        [Column("Description_Sinhala", TypeName = "LONGTEXT")]
        public string Description_Sinhala { get; set; }

        [Column("Description_Tamil", TypeName = "LONGTEXT")]
        public string Description_Tamil { get; set; }


        //[Column("FK_Supplier_Item_Code")]
        //public string FK_Supplier_Item_Code { get; set; }

        //[Column("FK_Supplier_Code")]
        //public string FK_Supplier_Code { get; set; }

        //  [ForeignKey("FK_Supplier_Item_Code,FK_Supplier_Code")]
        //public Supplier_Item Supplier_Items { get; set; }

        [Required]
        [Column("Order")]
        public int Order { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
    }
}