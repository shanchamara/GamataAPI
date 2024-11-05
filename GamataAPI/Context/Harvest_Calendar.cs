using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("m_harvest_calendar")]
    public class Harvest_Calendar
    {
        [Key, Column("FK_Product_Code")]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        public bool January { get; set; } = false;

        public bool February { get; set; } = false;

        public bool March { get; set; } = false;

        public bool April { get; set; } = false;

        public bool May { get; set; } = false;

        public bool June { get; set; } = false;

        public bool July { get; set; } = false;

        public bool August { get; set; } = false;

        public bool September { get; set; } = false;

        public bool October { get; set; } = false;

        public bool November { get; set; } = false;

        public bool December { get; set; } = false;


        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations
    }
}