using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Entities
{
    public class CustomerFeedback
    {
        [Key]
        public long CustomerFeedback_id {get;set;}
        public long Customer_id { get; set; }
        [Required]
        public long ? OfferedService_id {get;set;}
        
        public string Feedback_comments{get;set;} = "I like it";
        public double Feedback_Rate{get;set;} = 0.00; 
        public string  Status {get;set;} = "approved";
        public DateTime Create_time { get; set; } = DateTime.UtcNow;
        public DateTime Last_upt_time { get; set; } = DateTime.UtcNow;
        
        
    }
}