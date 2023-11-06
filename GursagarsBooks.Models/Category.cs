using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace GursagarsBooks.Models
{
   public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name="Category Name")]
        [Required]
        [MaxLength(50)]

        public string Name { get; set; }
    }
}
