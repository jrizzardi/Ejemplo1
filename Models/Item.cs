using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TablaChina.Models
{
    public class Item
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Required Name")]
        public string name { get; set; }


        [Required(ErrorMessage = "Required Price")]
        public double Price { get; set; }

    }
}

