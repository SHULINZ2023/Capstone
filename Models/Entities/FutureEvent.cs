using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class FutureEvent
    {
        [Key]
        public long FutureEvent_id { get; set; }
        [Required]
        public string ? FutureEvent_name { get; set; }
        public string ? FutureEvent_contact {get;set;}
        public string ? FutureEvent_desc {get;set;}
        public string ? FutureEvent_photo_url {get;set;}
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
        public string ? FutureEvent_video_link {get;set;}

        public string ? ServiceCostPolicy {get;set;}
        [Required]       
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}