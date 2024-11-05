using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_diseases_control_method")]
    public class CRB_Diseases_Control_Method
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_CRB_Code")]
        public int FK_CRB_Code { get; set; }

        [ForeignKey("FK_CRB_Code")]
        public Crop_Record_Book Crop_Record_Book { get; set; }

        public string Crop_Area { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Pest_Name { get; set; } = string.Empty;
        public string Liquid_Name { get; set; } = string.Empty;
        public bool Is_Registered_Pesticide { get; set; } = false;
        public string Recommended_Company_Name { get; set; } = string.Empty;
        public decimal Applied_Quantity { get; set; } = 0.0m;
        public DateTime Applied_Date { get; set; } = DateTime.Now;
        public string Applied_Method { get; set; } = string.Empty;
        public string Batch_Code { get; set; } = string.Empty;
        public string Applied_Person_Name { get; set; } = string.Empty;
        public string Purchase_Method { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
