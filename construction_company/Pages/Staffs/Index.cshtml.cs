using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using construction_company.Data;
using construction_company.Models;

namespace construction_company.Pages.Staffs
{
    public class IndexModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public IndexModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get;set; }
        public IList<position> position { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            position = await _context.position.ToListAsync();
        }
    }
}
