using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlogPost.Models;

namespace BlogPost.Data
{
    public class BlogPostContext : DbContext
    {
        public BlogPostContext (DbContextOptions<BlogPostContext> options)
            : base(options)
        {
        }

        public DbSet<BlogPost.Models.Blog> Blog { get; set; }
    }
}
