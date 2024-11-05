using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_planting_material")]
    public class CRB_has_Planting_Material
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
        public DateTime Planted_Date { get; set; } = DateTime.Now;
        public string Product_Name { get; set; } = string.Empty;
        public bool Is_Pataka_Ropanaya { get; set; } = false;
        public decimal Area { get; set; } = 0.0m;
        public string Ropana_Treatment { get; set; } = string.Empty;
        public string Ropana_Purchase_Supplier { get; set; } = string.Empty;

        public string Ropana_Certification_and_Body { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
