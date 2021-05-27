using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace construction_company.Models
{
    public class Orders
    {
        [Display(Name = "Код заказа")]
        public long ID { get; set; }


        [Display(Name = "Дата начала")]
        public DateTime StartData { get; set; }


        [Display(Name = "Дата окончания")]
        public DateTime EndData { get; set; }


        [Display(Name = "Отметка завершения")]
        public string CompletionMark { get; set; }



        [Display(Name = "Об оплате")]
        public string AboutPayment { get; set; }



        [Display(Name = "Цена")]
        public int Price { get; set; }



        [Display(Name = "Код заказчика")]
        public long? CustomersID { get; set; }

        [Display(Name = "Заказчик")]
        public DbSet<Customers> Customers { get; set; }



        [Display(Name = "Код вида работы")]
        public long? TypesOfWorkID { get; set; }

        [Display(Name = "Вид работы")]
        public DbSet<TypesOfWork> TypesOfWork { get; set; }



        [Display(Name = "Код бригады")]
        public long? BrigadesID { get; set; }

        [Display(Name = "Бригада")]
        public DbSet<Brigades> Brigades { get; set; }


        [Display(Name = "Код сотрудника")]
        public long? StaffID { get; set; }

        [Display(Name = "Сотрудник")]
        public DbSet<Staff> Staff { get; set; }
    }
}
