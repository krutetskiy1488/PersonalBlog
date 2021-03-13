using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Заполните название услуги")]
        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } 
        
        [Display(Name = "Краткое описание услуги")]
        public override string Subtitle { get; set; } = "Информационная страница";

        [Display(Name = "Полное описание страницы")]
        public override string Text { get; set; } = "Содержание заполняется админом";
    }
}
