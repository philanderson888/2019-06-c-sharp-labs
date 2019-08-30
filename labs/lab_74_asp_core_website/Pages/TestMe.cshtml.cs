using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using lab_74_asp_core_website.Models;

namespace lab_74_asp_core_website.Pages
{
    public class TestMeModel : PageModel
    {
        private readonly lab_74_asp_core_website.Models.Northwind _context;

        public TestMeModel(lab_74_asp_core_website.Models.Northwind context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customers.ToListAsync();
        }
    }
}
