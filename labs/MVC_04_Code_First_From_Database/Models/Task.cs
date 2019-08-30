using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_04_Code_First_From_Database.Models
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskDescription { get; set; }

        [Display(Description = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }
    }
}
