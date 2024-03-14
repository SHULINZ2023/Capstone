using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class Gallery
    {
        [Key]
        public long Gallery_id { get; set; }
        [Required]
        public string ? Gallery_name { get; set; }
       
        public string ? Gallery_photo_uri {get;set;}
        public string ? Gallery_Video_uri {get;set;}
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}