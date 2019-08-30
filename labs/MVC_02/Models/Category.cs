using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_02.Models
{
    public class Category
    {
        public Category()
        {
            Tests = new HashSet<Test>();
        }

        public int CategoryID { get; set; }
        public string CategoryName { get;set; }

        public virtual ICollection<Test> Tests { get; set; }
    }
}
