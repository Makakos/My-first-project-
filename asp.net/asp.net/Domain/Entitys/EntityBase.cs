using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace asp.net.Domain.Entitys
{
    public abstract class EntityBase
    {
        protected EntityBase() { DateAdded = DateTime.UtcNow; }

        [Required]
        public Guid Id { get; set; }
        [Display(Name="Название")]
        public virtual string Title { get; set; }
        [Display(Name = "Короткое описание")]
        public virtual string Subtitle { get; set; }
        [Display(Name = "Полное описание")]
        public virtual string Text { get; set; }
        [Display(Name = "Тутульная картинка")]
        public virtual string TitleImagePath { get; set; }
        [Display(Name = "Метатег Title")]
        public string MetaTitle { get; set; }
        [Display(Name = "Метатег Desvription")]
        public string MetaDiscription { get; set; }
        [Display(Name = "Метатег Keyes")]
        public string MetaKeyes { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime DateAdded { get; set; }
    }
}
