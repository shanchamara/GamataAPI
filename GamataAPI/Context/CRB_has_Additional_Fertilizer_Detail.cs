using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_additional_fertilizer_detail")]
    public class CRB_has_Additional_Fertilizer_Detail
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

        [Required]
        public bool Is_Organic_Fertilizer { get; set; }

        public DateTime Applied_Date { get; set; }
        public string Organic_Type { get; set; } = string.Empty;
        public string Applied_Product { get; set; }
        public decimal Voulme { get; set; } = 0.0m;
        public string Applied_Method { get; set; } = string.Empty;
        public string Batch_No { get; set; } = string.Empty;
        public string Applied_Person_Name { get; set; } = string.Empty;
        public string Recommended_Company { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
