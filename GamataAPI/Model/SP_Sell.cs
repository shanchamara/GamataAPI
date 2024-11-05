namespace GamataAPI.Context
{
    public class SP_Sell
    {
        public string Code { get; set; }
        public string Quantity { get; set; }
        public decimal Unit_Price { get; set; }
        public int RnUserID { get; set; }
        public string UOM { get; set; }
        public string Display_Available_DateTime { get; set; }
        public string Display_Expired_DateTime { get; set; }
        public DateTime Available_DateTime { get; set; }
        public DateTime Expired_DateTime { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Name_English { get; set; }
        public string Name_Sinhala { get; set; }
        public string Name_Tamil { get; set; }
        public string GramaSewa { get; set; }
        public string Division { get; set; }
        public string District { get; set; }
        public string FK_Country_Type { get; set; }
        public string FK_Country_Code { get; set; }
        public string FK_Country_Parent { get; set; }
        public string Remark { get; set; }
        public string Location_Description { get; set; }
        public string Super_Parent { get; set; }

        public string p3 { get; set; }
        public string p2 { get; set; }
        public string p1 { get; set; }



        public string Thumbnail { get; set; }

        public string ProfileImage { get; set; }
    }
}
