using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lendmyautoinfo.Models
{
    public class ContactUsData
    {
        public string EmailAddress { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public string AlertName { get; set; }
    }
}