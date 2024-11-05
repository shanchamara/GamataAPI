﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_crb_harvest_activity_detail")]
    public class CRB_Harvest_Activity_Detail
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

        public DateTime Harvest_Date { get; set; } = DateTime.Now;
        public string Product_Name { get; set; } = string.Empty;
        public string Batch_Code { get; set; } = string.Empty;
        public decimal Harvest_Quantity { get; set; } = 0.0m;
        public Decimal Harvest_After_Production_Quantity { get; set; } = 0.0m;

        public string Export_Quantity { get; set; } = string.Empty;
        public string Local_Market_Quantity { get; set; } = string.Empty;


        public string Other_Applies { get; set; } = string.Empty;

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }
    }
}
