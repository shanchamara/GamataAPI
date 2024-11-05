namespace GamataAPI.Context
{
    public class SP_Listings
    {

        public int Code { get; set; }
        public string Image { get; set; } = "default.jpg";

        public string FK_Country_Code { get; set; }


        public string FK_Country_Type { get; set; }

        public string FK_Country_Parent { get; set; }

        public string Name_Sinhala { get; set; }


        public string Name_English { get; set; }

        public string Name_Tamil { get; set; }
        public string Location { get; set; }

        public string FLastModifiedOn { get; set; }
        public string Group_of_Company { get; set; }

        public bool IsOutlet { get; set; }

        public string Product_Category { get; set; }


        public string Telephone { get; set; }

        public string Whatsup { get; set; }

        public string Address { get; set; }

        public string Products_Sinhala { get; set; }


        public string Products_English { get; set; }

        public string Products_Tamil { get; set; }

        public string grama { get; set; }
        public string division { get; set; }
        public string district { get; set; }
        public string province { get; set; }

    }
}
