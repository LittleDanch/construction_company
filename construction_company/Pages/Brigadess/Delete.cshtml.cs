using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using construction_company.Data;
using construction_company.Models;

namespace construction_company.Pages.Brigadess
{
    public class DeleteModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public DeleteModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Brigades Brigades { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigades = await _context.Brigades.FirstOrDefaultAsync(m => m.ID == id);

            if (Brigades == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Brigades = await _context.Brigades.FindAsync(id);

            if (Brigades != null)
            {
                _context.Brigades.Remove(Brigades);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
