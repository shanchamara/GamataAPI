using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_material_purchase")]
    public class CRB_has_Material_Purchase
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

        public DateTime Purchase_Date { get; set; } = DateTime.Now;


        public string Material_Type { get; set; } = string.Empty;

        public decimal Volume { get; set; } = 0.0m;

        public string Purchased_Location { get; set; } = string.Empty;

        public string Batch_No { get; set; } = string.Empty;

        public DateTime Manufacture_Date { get; set; }

        public string Expired_Date { get; set; } = string.Empty;

        public string Manufacturer { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
