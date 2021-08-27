using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalianShopApplication.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }


        [Display(Name = "Название страницы (заголовок)")]
        public override string Title { get; set; } = "Information Page";

        [Display(Name = "Содержание страницы")]
        public override string Text { get; set; } = "Written by admin";
    }
}
