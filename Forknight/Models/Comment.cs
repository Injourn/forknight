using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forknight.Models
{
    public class Comment
    {
        public int UserID { get; set; }
        public string Content { get; set; }

        public DateTime TimePosted { get; set; }
        public int Rating { get; set; }
    }
}
