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
    public class IndexModel : PageModel
    {
        private readonly construction_company.Data.construction_companyContext _context;

        public IndexModel(construction_company.Data.construction_companyContext context)
        {
            _context = context;
        }

        public IList<Orders> Orders { get;set; }
        public IList<Customers> Customers { get; set; }
        public IList<TypesOfWork> TypesOfWork { get; set; }
        public IList<Brigades> Brigades { get; set; }
        public IList<Staff> Staff { get; set; }

        public async Task OnGetAsync()
        {
            Orders = await _context.Orders.ToListAsync();
            Customers = await _context.Customers.ToListAsync();
            TypesOfWork = await _context.TypesOfWork.ToListAsync();
            Brigades = await _context.Brigades.ToListAsync();
            Staff = await _context.Staff.ToListAsync();
        }
    }
}
