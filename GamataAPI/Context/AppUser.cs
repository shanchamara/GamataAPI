using GamataAPI.Model;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GamataAPI.Context
{
    public class AppUser : IdentityUser
    {
        [Required]
        [MaxLength(300)]
        public string Name { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Address { get; set; }

        [MaxLength(45)]
        public string Division { get; set; }

        [MaxLength(45)]
        public string GramasewaDivision { get; set; }

        [MaxLength(45)]
        public string District { get; set; }

        [MaxLength(45)]
        public string Province { get; set; }

        [MaxLength(45)]
        public string PostalCode { get; set; }

        [MaxLength(45)]
        public string Country { get; set; }

        [MaxLength(45)]
        public string IdentificationType { get; set; }

        [MaxLength(45)]
        public string IdentificationID { get; set; }

        [Column(TypeName = "mediumtext")]
        public string Remark { get; set; }

        public bool IsActive { get; set; } = false;

        [MaxLength(80)]
        public string ProfileImage { get; set; }

        [MaxLength(100)]
        public string Incorporation { get; set; }

        [MaxLength(50)]
        public string IncorporationNo { get; set; }

        [MaxLength(100)]
        public string StoreName { get; set; }

        ///additonal
        [Required]
        public DateTime InsertedOn { get; set; } = DateTime.Now;
        [Required]
        public DateTime LastModifiedOn { get; set; } = DateTime.Now;
        public int LastModifiedBy { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public string LastUpdatedBy { get; set; }
        public DateTime LastUpdatedDateTime { get; set; } = DateTime.Now;
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDateTime { get; set; }

        public DateTime? Join_date { get; set; }
        public string Designation { get; set; }
        public string NIC_no { get; set; }
        public DateTime LastLoginDate { get; set; }

        public Boolean AcceptTerms { get; set; } = false;
        public string ImageURl { get; set; }

        ///relations
        public ICollection<Farming_Location> Farming_Locations { get; set; }
        public ICollection<Farming_Product> Farming_Products { get; set; }
        public ICollection<Plan> Plans { get; set; }
        public ICollection<Post_Comment> Comments { get; set; }
        public ICollection<Post_Like> Likes { get; set; }
        public ICollection<Sell> Sells { get; set; }

        public ICollection<WishList> WishLists { get; set; }
        public ICollection<Sell_Rate> Ratings { get; set; }
        public ICollection<Inquiry> Inquries { get; set; }
        public ICollection<Inquiry_has_Message> InquryMessages { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public ICollection<Crop_Record_Book> Crop_Record_Books { get; set; }

        // new modification
        public ICollection<Temp_Shopping_Cart> Temp_Shopping_Cart { get; set; }

        public ICollection<Order_Header> Order_Header { get; set; }

        public ICollection<AppToken> AppTokens { get; set; }
        ///// <summary>
        /////  Helpers
        ///// </summary>

        //[NotMapped]
        //[Required(ErrorMessage ="Please Select the Province")]
        //public DropDown ProvinceObj { get; set; }

        //[NotMapped]
        //[Required(ErrorMessage = "Please Select the District")]
        //public DropDown DistrictObj { get; set; }

        //[NotMapped]
        //[Required(ErrorMessage = "Please Select the Division")]
        //public DropDown DivisionObj { get; set; }

        //[NotMapped]
        //[Required(ErrorMessage = "Please Select the Grama Sewa Division")]
        //public DropDown GramasewaDivisionObj { get; set; }

        //[NotMapped]
        //[Required(ErrorMessage = "Terms and condition is required")]
        //public bool IsAgreedToTerms { get; set; }

        //[NotMapped]
        //public string ProfilePicBase64 { get; set; }





    }


}