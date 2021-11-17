using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PermissionBasedAuthorizationIntDotNet5.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermissionBasedAuthorizationIntDotNet5.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
    }
}
