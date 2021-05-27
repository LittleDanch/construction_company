using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class Customers
    {
        [Display(Name = "Код заказчика")]
        public long ID { get; set; }



        [Display(Name = "ФИО")]
        public string FullName { get; set; }


        [Display(Name = "Возраст")]
        public int Age { get; set; }



        [Display(Name = "Адрес")]
        public string Address { get; set; }



        [Display(Name = "Телефон")]
        public string Phone { get; set; }


        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }

    }
}
