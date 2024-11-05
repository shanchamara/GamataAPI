namespace GamataAPI.Context
{
    public class SP_Plan
    {
        public int Code { get; set; }
        public string Area { get; set; }
        public DateTime Start_DateTime { get; set; }
        public string Display_Start_DateTime { get; set; }
        public DateTime End_DateTime { get; set; }
        public string Display_End_DateTime { get; set; }
        public string UOM { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public string ProfileImage { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Name_English { get; set; }
        public string Name_Sinhala { get; set; }
        public string Name_Tamil { get; set; }
        public string GramaSewa_English { get; set; }
        public string GramaSewa_Sinhala { get; set; }
        public string GramaSewa_Tamil { get; set; }

        public float pracentage { get; set; }
        public string Division_English { get; set; }
        public string Division_Sinhala { get; set; }
        public string Division_Tamil { get; set; }


        public string District_English { get; set; }
        public string District_Sinhala { get; set; }
        public string District_Tamil { get; set; }

        public string Province_English { get; set; }
        public string Province_Sinhala { get; set; }
        public string Province_Tamil { get; set; }



        public string Super_Parent_English { get; set; }
        public string Super_Parent_Sinhala { get; set; }
        public string Super_Parent_Tamil { get; set; }

    }
}
