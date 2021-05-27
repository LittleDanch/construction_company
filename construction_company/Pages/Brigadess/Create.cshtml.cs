using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using construction_company.Data;
using construction_company.Models;

namespace construction_company.Pages.Brigadess
{
    public class CreateModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public CreateModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Brigades Brigades { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Brigades.Add(Brigades);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
