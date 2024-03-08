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
        public string ? BusinessProfile_contact {get;set;}
        public string ? BusinessProfile_desc {get;set;}
        public string ? BusinessProfile_photo_url {get;set;}
        public string ? Kind1_foto1_uri {get;set;}
        public string ? Kind1_foto2_uri {get;set;}
        public string ? Kind1_foto3_uri {get;set;}
        public string ? Kind1_foto4_uri {get;set;}
        public string ? Kind1_foto5_uri {get;set;}

        public string ? Kind2_foto1_uri {get;set;}
        public string ? Kind2_foto2_uri {get;set;}
        public string ? Kind2_foto3_uri {get;set;}
        public string ? Kind2_foto4_uri {get;set;}
        public string ? Kind2_foto5_uri {get;set;}        
        public string ? Kind3_foto1_uri {get;set;}
        public string ? Kind3_foto2_uri {get;set;}
        public string ? Kind3_foto3_uri {get;set;}
        public string ? Kind3_foto4_uri {get;set;}
        public string ? Kind3_foto5_uri {get;set;} 
        public string ? BusinessProfile_video_link {get;set;}
        public int business_start_year{get;set;}
        [Required]       
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}