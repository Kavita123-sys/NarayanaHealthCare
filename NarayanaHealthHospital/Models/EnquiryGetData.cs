using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NarayanaHealthHospital.Models
{
    public class EnquiryGetData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Contact { get; set; }
        public  string Query { get; set; }
        public int City_id { get; set; }
        public int Hospital_id { get; set; }
     }
    

}