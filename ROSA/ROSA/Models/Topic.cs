using System;
using System.Collections.Generic;
using System.Text;

namespace ROSA.Models
{
    public class Topic
    {
        
        public string Code { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Till { get; set; }
        public DateTime Since { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
