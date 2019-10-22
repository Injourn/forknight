using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Forknight.Models;

namespace Forknight.Data
{
    public class ForknightCommentContext : DbContext
    {
        public ForknightCommentContext(DbContextOptions<ForknightCommentContext> options) : base(options) {

        }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Forknight.Models.Listing> Listing { get; set; }

    }
}
