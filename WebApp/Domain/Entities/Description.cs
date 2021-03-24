using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain.Entities
{
    public class Description : EntityBase
    {
        [Display(Name = "Личная информация")]
        public override string Text { get; set; } = "Я Семен";
    }
}
