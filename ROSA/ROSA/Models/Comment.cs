using System;
using System.Collections.Generic;
using System.Text;

namespace ROSA.Models
{
    public class Comment
    {

        
        public string Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Content { get; set; }
        public Topic Topic { get; set; }
        public User User { get; set; }

    }
}
