namespace NarayanaHealthHospital.Models
{
    public class EnquiryInternationalModel
    {
        public int ID { get; set; }
        public string First_Name  { get; set; }
        public string Last_Name{ get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public string Nationality_id { get; set; }
        public string Country_id { get; set; }
        public long Query { get; set; }
    }
}