using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_03.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaskID { get; set; }
        public string Description { get; set; }
        
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate {get;set;}
    }
}
