using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaFamily.Models;

namespace PizzaFamily.Pages
{
	public class MenuPizzaModel : PageModel
    {
        private readonly PizzaFamily.Data.DataContext _context;

        public MenuPizzaModel(PizzaFamily.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            Pizza = await _context.Pizzas.ToListAsync();
        }
    }
}
