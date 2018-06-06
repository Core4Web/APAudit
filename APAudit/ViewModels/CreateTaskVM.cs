using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APAudit.ViewModels
{
    public class CreateTaskVM
    {
        public int Id { get; set; }
        [Display(Name = "Регион")]
        public string District { get; set; }
        [Display(Name ="Провайдер")]
        public string Operator { get; set; }
        [Display(Name = "Адрес точки доступа")]
        public string Address { get; set; }
        [Display(Name = "Телефон проверяющего")]
        public string Phone { get; set; }
        [Display(Name = "Примечание")]
        public string Notes { get; set; }

        public List<SelectListItem> Districts { get; set; }
    }
}
