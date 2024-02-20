using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class PrivateChef
    {
        [Key]
        public long PrivateChef_id { get; set; }
        [Required]
        public string ? PrivateChef_name { get; set; }
        public string ? PrivateChef_contact {get;set;}
        public string ? PrivateChef_desc {get;set;}
        public string ? PrivateChef_photo_url {get;set;}
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
        public string ? PrivateChef_video_link {get;set;}
        [Required]       
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}