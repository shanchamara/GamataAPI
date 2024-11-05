using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_irrigation_detail")]
    public class CRB_Irrigation_Detail
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

        public bool Is_Water_Flow_Through_Valid_Places { get; set; } = false;
        public bool Is_Valid_Water_Sources { get; set; } = false;
        public bool Is_Chemical_Risky { get; set; } = false;
        public bool Is_Chemical_Research_Done { get; set; } = false;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
