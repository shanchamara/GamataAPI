using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_product_instructions")]
    public class Product_Instruction
    {
        [Key, Column("FK_Product_Code", Order = 0)]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        [Key, Column("FK_Activity_Code", Order = 1)]
        public string FK_Activity_Code { get; set; }

        [ForeignKey("FK_Activity_Code")]
        public Activity Activitiy { get; set; }

        [Required]
        [Column("Description_English", TypeName = "LONGTEXT")]
        public string Description { get; set; }

        [Column("Description_Sinhala", TypeName = "LONGTEXT")]
        public string Description_Sinhala { get; set; }

        [Column("Description_Tamil", TypeName = "LONGTEXT")]
        public string Description_Tamil { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations

    }
}