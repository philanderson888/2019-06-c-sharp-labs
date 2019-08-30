using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_02.Models
{
    public class Test
    {
        public int TestID { get; set; }
        public string TestDescription { get; set; }


        [Display(Name = "Date Of Entry")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,
              DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TestDate { get; set; }

        [Display(Name = "CategoryName")]
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
