using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class Material
    {
        [Display(Name = "Код материала")]
        public long ID { get; set; }




        [Display(Name = "Наименование")]
        public string Name { get; set; }



        [Display(Name = "Упаковка")]
        public string Packaging { get; set; }



        [Display(Name = "Описание")]
        public string Description { get; set; }



        [Display(Name = "Цена")]
        public int Price { get; set; }

    }
}
