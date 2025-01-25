using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaFamily.Data;
using PizzaFamily.Models;

namespace PizzaFamily.Pages.Admin.Pizzas
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly PizzaFamily.Data.DataContext _context;

        public IndexModel(PizzaFamily.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
