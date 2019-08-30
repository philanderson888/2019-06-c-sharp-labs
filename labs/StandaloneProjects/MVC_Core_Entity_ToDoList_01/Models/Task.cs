using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Core_Entity_ToDoList_01.Models
{
    public class Task
    {
        public int TaskID { get; set; }
        public string TaskName { get; set; }

        [Display(Name ="Due Date")]
        [DataType(DataType.Date)]

        public DateTime DueDate { get; set; }

        // foreign key CategoryID
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}
