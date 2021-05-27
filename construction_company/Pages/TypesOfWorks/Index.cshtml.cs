using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using construction_company.Data;
using construction_company.Models;

namespace construction_company.Pages.TypesOfWorks
{
    public class IndexModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public IndexModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public IList<TypesOfWork> TypesOfWork { get;set; }
        public IList<Material> Material { get; set; }

        public async Task OnGetAsync()
        {
            TypesOfWork = await _context.TypesOfWork.ToListAsync();
            Material = await _context.Material.ToListAsync();
        }
    }
}
