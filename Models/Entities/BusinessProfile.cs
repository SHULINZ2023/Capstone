using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class BusinessProfile
    {
        [Key]
        public long BusinessProfile_id { get; set; }
        [Required]
        public string ? BusinessProfile_name { get; set; }
        public string ? BusinessProfile_owner {get;set;}
        public string ? BusinessProfile_desc {get;set;}
        public string ? BusinessProfile_address {get;set;}
        public string ? BusinessProfile_email{get;set;}
        public string ? BusinessProfile_phone{get;set;}
        public string ? BusinessProfile_photo_url {get;set;}
        public string ? BusinessProfile_video_link {get;set;}
        public int business_start_year{get;set;}
        [Required]       
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}