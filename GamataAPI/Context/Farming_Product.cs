using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    [Table("t_farming_product")]
    public class Farming_Product
    {
        [Key, Column("FK_UserID", Order = 0)]
        public string FK_UserID { get; set; }

        [ForeignKey("FK_UserID")]
        public AppUser User { get; set; }

        [Key, Column("FK_Product_Code", Order = 1)]
        public string FK_Product_Code { get; set; }

        [ForeignKey("FK_Product_Code")]
        public Product Product { get; set; }

        public bool IsDeleted { get; set; } = false;

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        ///relations

    }


}