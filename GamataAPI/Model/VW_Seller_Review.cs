namespace GamataAPI.Context
{
    public class VW_Seller_Review
    {
        public string Buyer_Name { get; set; }
        public int FK_Buyer_UserID { get; set; }

        public int FK_Seller_UserID { get; set; }

        public int Buyer_Rate { get; set; }

        public string Comment { get; set; }

        public string ProfileImage { get; set; }

        public string Buyer_RateOn { get; set; }
    }
}
