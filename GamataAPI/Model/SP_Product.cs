namespace GamataAPI.Context
{
    public class SP_Product
    {
        public string Name_English { get; set; }
        public string Name_Sinhala { get; set; }
        public string Name_Tamil { get; set; }
        public string Code { get; set; }

        public int Page { get; set; } = 1;
        public List<SP_Product> Items { get; set; }
    }
}
