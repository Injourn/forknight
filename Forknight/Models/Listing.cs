using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forknight.Models
{
    public class Listing
    {
        public int Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
        //https://www.aspforums.net/Threads/153525/How-to-Display-Image-from-Database-Using-View-Models-in-ASPNet-MVC-5/ just in case
        byte[] Photo { get; set; }
    }
}
