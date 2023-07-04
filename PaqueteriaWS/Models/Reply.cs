using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaqueteriaWS.Models
{
    public class Reply
    {
        public int statusCode{ get; set; }
        public string message { get; set; }
        public object data { get; set; }    
    }
}