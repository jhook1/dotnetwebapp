#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using netwebapp.Data;
using netwebapp.Models;

namespace netwebapp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly netwebapp.Data.netwebappContext _context;

        public IndexModel(netwebapp.Data.netwebappContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
