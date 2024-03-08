using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class Customer
    {
        [Key]
        public long Customer_id { get; set; }
        [Required]
        public string ? Customer_name { get; set; }
        public string ? Customer_address {get;set;}
        public string ? Customer_phone {get;set;}
        public string ? Customer_email {get;set;}
        public string ? Customer_desc {get;set;}
        public string ? Customer_photo_uri {get;set;}
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}