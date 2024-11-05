using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_chemical_detail")]
    public class CRB_has_Chemical_Detail
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
        public string Control_Type { get; set; }

        public string Veed_Name { get; set; } = string.Empty;
        public string Chemical_Name { get; set; } = string.Empty;
        public DateTime Applied_Date { get; set; } = DateTime.Now;
        public decimal Volume { get; set; } = 0.0m;
        public string Applied_Method { get; set; } = string.Empty;
        public string Recommended_Company { get; set; } = string.Empty;
        public string Applied_Person_Name { get; set; } = string.Empty;
        public string Batch_No { get; set; } = string.Empty;
        public bool Is_Registed_Herbicide { get; set; } = false;

        public bool IsDeleted { get; set; } = false;
        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
