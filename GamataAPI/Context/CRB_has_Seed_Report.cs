using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_seed_report")]
    public class CRB_has_Seed_Report
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
        public DateTime Plantation_Date { get; set; } = DateTime.Now;
        public string Seed_Name { get; set; } = string.Empty;
        public bool Is_Seed_Hybrid { get; set; } = false;
        public decimal Area { get; set; } = 0.0m;
        public string Seed_Cert_Detail { get; set; } = string.Empty;
        public string Seed_Treatment_Detail { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
