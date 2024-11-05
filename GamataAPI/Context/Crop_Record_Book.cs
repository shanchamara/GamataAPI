using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crop_record_book")]
    public class Crop_Record_Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("Code")]
        public int Code { get; set; }

        [Required]
        [Column("FK_UserID")]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser Users { get; set; }

        [Required]
        [Column("FK_Product_Code")]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        public decimal Farming_Location_Area { get; set; } = 0.0m;

        public int Trained_Staff_Count { get; set; } = 0;

        public int Trainee_Staff_Count { get; set; } = 0;

        public string Traget_Market { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        /////relations
        public virtual CRB_Location_Detail CRB_Location_Detail { get; set; }
        public ICollection<CRB_has_Planting_Material> CRB_has_Planting_Materials { get; set; }
        public ICollection<CRB_has_Seed_Report> CRB_has_Seed_Reports { get; set; }
        public ICollection<CRB_has_Material_Purchase> CRB_has_Material_Purchases { get; set; }
        public ICollection<CRB_has_Fertilizer_Detail> CRB_has_Fertilizer_Details { get; set; }
        public ICollection<CRB_has_Combined_Pest_Control_Detail> CRB_has_Combined_Pest_Control_Details { get; set; }
        public ICollection<CRB_has_Chemical_Detail> CRB_has_Chemical_Details { get; set; }
        public ICollection<CRB_has_Additional_Fertilizer_Detail> CRB_has_Additional_Fertilizer_Details { get; set; }
        public ICollection<CRB_Diseases_Control_Method> CRB_Diseases_Control_Methods { get; set; }
        public ICollection<CRB_Irrigation_Detail> CRB_Irrigation_Details { get; set; }
        public ICollection<CRB_Irrigation_Report> CRB_Irrigation_Reports { get; set; }
        public ICollection<CRB_Employee_Training_Report> CRB_Employee_Training_Reports { get; set; }
        public ICollection<CRB_Harvest_Activity_Detail> CRB_Harvest_Activity_Details { get; set; }
        public ICollection<CRB_Wast_Harvest_Record> CRB_Wast_Harvest_Records { get; set; }
    }
}


