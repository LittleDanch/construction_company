using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using construction_company.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace construction_company.Pages.ZF.Filters
{  
        public class Selected_positionsModel : PageModel
        {
            private readonly construction_company.Data.construction_companyContext _context;

            public Selected_positionsModel(construction_company.Data.construction_companyContext context)
            {
                _context = context;
            }

            public IList<Staff> Staff { get; set; }
            public position position { get; set; }

            public async Task<IActionResult> OnGetAsync(long? id)
            {
                if (id == null)
                {
                    return NotFound();
                }

                position = await _context.position.FirstOrDefaultAsync(m => m.ID == id);

                if (position == null)
                {
                    return NotFound();
                }
                Staff = await _context.Staff.Where(m => m.positionID == position.ID).ToListAsync();
                return Page();
            }
        }
    }

