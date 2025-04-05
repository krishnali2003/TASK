using System;

namespace CompanyApiJwt.Models
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyGSTN { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyUserId { get; set; }
        public string CompanyStatus { get; set; }
        public DateTime CompanyStartdate { get; set; }
        public string CompanyNatureofWork { get; set; }
    }
}
