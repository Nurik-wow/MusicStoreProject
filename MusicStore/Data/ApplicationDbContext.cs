using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MusicStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace MusicStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
            : base (options)
        {
            
        }
    }
}
