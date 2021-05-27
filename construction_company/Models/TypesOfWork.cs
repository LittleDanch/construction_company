using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class TypesOfWork
    {
        [Display(Name = "Код вида работы")]
        public long ID { get; set; }



        [Display(Name = "Наименование")]
        public string Name { get; set; }


        [Display(Name = "Описание")]
        public string Description { get; set; }


        [Display(Name = "Цена")]
        public int Price { get; set; }



        [Display(Name = "Код материала 1")]
        public long? Material1ID { get; set; }

        [Display(Name = "Материал 1")]
        public DbSet<Material> Material1 { get; set; }



        [Display(Name = "Код материала 2")]
        public long? Material2ID { get; set; }

        [Display(Name = "Материал 2")]
        public DbSet<Material> Material2 { get; set; }




        [Display(Name = "Код материала 3")]
        public long? Material3ID { get; set; }

        [Display(Name = "Материал 3")]
        public DbSet<Material> Material3 { get; set; }

    }
}
