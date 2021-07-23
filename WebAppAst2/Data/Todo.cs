using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppAst2.Data
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public Boolean Done { get; set;}
        [StringLength(255)]
        public String Name { get; set; }
        public String Desc { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;

    }
}
