namespace GamataAPI.Context
{
    public class SP_Latest
    {
        public string Code { get; set; }
        public string Quantity { get; set; }
        public decimal Unit_Price { get; set; }

        public string UOM { get; set; }

        public DateTime Available_DateTime { get; set; }
        public DateTime Expired_DateTime { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Name_English { get; set; }
        public string Name_Sinhala { get; set; }
        public string Name_Tamil { get; set; }
        public string Super_Parent { get; set; }
        public string Thumbnail { get; set; }

        public string ProfileImage { get; set; }

        public string Super_Parent_Name_English { get; set; }
        public string Super_Parent_Name_Sinhala { get; set; }
        public string Super_Parent_Name_Tamil { get; set; }
    }
}
