using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using construction_company.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace construction_company.Pages.ZF.Requests
{
    public class Human_Resources_DepartmentModel : PageModel
    {
        
            private readonly construction_company.Data.construction_companyContext _context;

        public Human_Resources_DepartmentModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public IList<Staff> Staff { get; set; }
        public IList<position> position { get; set; }

        public async Task OnGetAsync()
        {
            Staff = await _context.Staff.ToListAsync();
            position = await _context.position.ToListAsync();
        }
    }
}
