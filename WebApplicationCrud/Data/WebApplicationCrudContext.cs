using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationCrud.Model;

namespace WebApplicationCrud.Data
{
    public class WebApplicationCrudContext : DbContext
    {
        public WebApplicationCrudContext (DbContextOptions<WebApplicationCrudContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationCrud.Model.User> User { get; set; } = default!;
    }
}
