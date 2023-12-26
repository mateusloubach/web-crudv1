using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplicationCrud.Data;
using WebApplicationCrud.Model;

namespace WebApplicationCrud.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly WebApplicationCrud.Data.WebApplicationCrudContext _context;

        public IndexModel(WebApplicationCrud.Data.WebApplicationCrudContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
