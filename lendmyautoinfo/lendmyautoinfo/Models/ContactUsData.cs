using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lendmyautoinfo.Models
{
    public class ContactUsData
    {
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Name { get; set; }
        
        public string Message { get; set; }
        public bool Success { get; set; }
        public string AlertName { get; set; }
        public bool Scroll { get; set; }
        [Required]
        public string Reason { get; set; }
    }
}