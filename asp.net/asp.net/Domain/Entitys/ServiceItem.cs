using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain.Entitys
{
    public class ServiceItem:EntityBase
    {
        [Required(ErrorMessage = "Заполните поле услуги")]
        [Display(Name = "Название услуги")]
        public override string Title { get; set; } = "Информационная страница";

    }
}
