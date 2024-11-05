using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_wast_harvest_record")]
    public class CRB_Wast_Harvest_Record
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

        public DateTime Record_Date { get; set; } = DateTime.Now;
        public string Product_Name { get; set; } = string.Empty;
        public decimal Wast_Quantity { get; set; } = 0.0m;
        public string Reason { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;
        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
