using System;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkMia.Models;

namespace EntityFrameworkMia
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options): base(options)
        {
        }

        public DbSet<Post> Post { get; set; }
    }
}
