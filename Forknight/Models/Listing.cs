using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forknight.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime dayListed { get; set; }
        public byte[] Image { get; set; }


    }
}
