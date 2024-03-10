using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class Section
    {
        [Key]
        public long Section_id { get; set; }
        [Required]
        public string ? Section_name { get; set; }
        public string ? Section_video {get;set;}
        public string ? Section_desc {get;set;}
        [MaxLength(30000)]
        public string ? Section_INNER_HTML {get;set;}
        
        public string ? Section_background_photo_uri {get;set;}
        public string ? Section_type {get;set;}
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
        public string ? Section_video_link {get;set;}

        [Required]       
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}