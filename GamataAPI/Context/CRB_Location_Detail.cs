using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_location_detail")]
    public class CRB_Location_Detail
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //[Column("Code")]
        //public int Code { get; set; }
        [Key]
        [ForeignKey("Crop_Record_Book")]
        public int FK_CRB_Code { get; set; }

        //[ForeignKey("FK_CRB_Code")]
        //public Crop_Record_Book Crop_Record_Book { get; set; }

        public string Land_Ownership { get; set; } = string.Empty;

        public string Land_Ownership_Other_Text { get; set; } = string.Empty;

        public bool Is_Plantation_History_Ok { get; set; } = false;
        public bool Is_Cultivatability_Ok { get; set; } = false;

        public bool Is_Cultivatability_Applied { get; set; } = false;
        public bool Is_Previously_Cultivated { get; set; } = false;

        public bool Is_Soil_Tested { get; set; } = false;

        public string Previously_Cultivated_Product { get; set; } = string.Empty;

        public string Previously_Used_Chemical { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        /////relations
        public virtual Crop_Record_Book Crop_Record_Book { get; set; }

    }
}


