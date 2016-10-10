using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ReviewModel
    {
        public  decimal stars { get; internal set; }
        public string body { get; internal set; }
        public string author { get; internal set; } 
    }
}