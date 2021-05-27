using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using construction_company.Data;
using construction_company.Models;

namespace construction_company.Pages.Orderss
{
    public class DetailsModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public DetailsModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public Orders Orders { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Orders = await _context.Orders.FirstOrDefaultAsync(m => m.ID == id);

            if (Orders == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
