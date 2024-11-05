using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_irrigation_report")]
    public class CRB_Irrigation_Report
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

        public DateTime Applied_Date { get; set; } = DateTime.Now;
        public string Crop_Area { get; set; } = string.Empty;
        public string Irrigation_Method { get; set; } = string.Empty;
        public string Water_Applied_Method { get; set; } = string.Empty;
        public string Batch_Code { get; set; } = string.Empty;
        public string Applied_Person_Name { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
