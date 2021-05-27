using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class position
    {
        [Display(Name = "Код должности")]
        public long ID { get; set; }



        [Display(Name = "Наименование должности")]
        public string Name_Position { get; set; }



        [Display(Name = "Оклад")]
        public int Salary { get; set; }



        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }



        [Display(Name = "Требования")]
        public string Requirements { get; set; }
    }
}
