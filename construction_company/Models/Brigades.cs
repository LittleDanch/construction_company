using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class Brigades
    {
        [Display(Name = "Код бригады")]
        public long ID { get; set; }




        [Display(Name = "Код сотрудника 1")]
        public long? Staff1ID { get; set; }

        [Display(Name = "Сотрудник 1")]
        public DbSet<Staff> Staff1 { get; set; }



        [Display(Name = "Код сотрудника 2")]
        public long? Staff2ID { get; set; }

        [Display(Name = "Сотрудник 2")]
        public DbSet<Staff> Staff2 { get; set; }



        [Display(Name = "Код сотрудника 3")]
        public long? Staff3ID { get; set; }

        [Display(Name = "Сотрудник 3")]
        public DbSet<Staff> Staff3 { get; set; }
    }
}
