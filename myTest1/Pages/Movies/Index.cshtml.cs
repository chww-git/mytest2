#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myTest1.Data;
using myTest1.Models;

namespace myTest1.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly myTest1.Data.myTest1Context _context;

        public IndexModel(myTest1.Data.myTest1Context context)
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
