using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Blog.Entities
{
    [Table("tblNews")]
    public class News
    {
        public int id { get; set; }
        public string title { get; set; }
        public string prew { get; set; }
        public string fulltext { get; set; }
        public string img { get; set; }
        public string author { get; set; }
    }
}
