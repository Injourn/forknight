using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forknight.Models;

namespace Forknight.Data
{
    public class ListingContext : DbContext
    {
        public ListingContext(DbContextOptions<ListingContext> options) :base(options) {

        }
        public DbSet<Listing> Listings { get; set; }

    }
}
