using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_has_combined_pest_control_detail")]
    public class CRB_has_Combined_Pest_Control_Detail
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

        public bool Is_Infection_Resistors { get; set; }
        public bool Is_Area_Specific_Seed { get; set; }
        public bool Is_Disease_Free_Seeds { get; set; }
        public bool Is_Recommended_Land_Prep { get; set; }
        public bool Is_Recommended_Distance { get; set; }
        public bool Is_Recommended_Fertilizer { get; set; }
        public bool Is_Recommended_Plantation { get; set; }
        public bool Is_Fence { get; set; }
        public bool Is_Successful_Veed_Removal { get; set; }
        public bool Is_Remove_Infected_Plants { get; set; }
        public bool Is_Ontime_Crop_Harvesting { get; set; }

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

    }
}
