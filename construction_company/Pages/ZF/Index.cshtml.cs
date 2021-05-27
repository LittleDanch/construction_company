using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace construction_company.Pages.ZF
{
    public class IndexModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public IndexModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }
        public List<SelectListItem> otdel { get; set; }
        public IActionResult OnGet()

        {
            otdel = _context.position.Select(p =>
                new SelectListItem
                {
                    Value = p.ID.ToString(),
                    Text = p.Name_Position
                }).ToList();
            return Page();
        }
    }
}