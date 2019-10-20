using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forknight.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public string Content { get; set; }
        [DataType(DataType.Date)]
        public DateTime TimePosted { get; set; }
        public int Rating { get; set; }
    }
}
