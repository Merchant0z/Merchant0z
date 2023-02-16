using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ChurchProject.Models
{
    public class Sermon
    {
        [Key]
        public int Id { get; set; }
        [Required]
       /* [Display(Name = "Sermon Topic")]*/
        public string Name { get; set; }
        [Display(Name = "Bible Text")]
        public string Text { get; set; }
        public string ShortDesc { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }
        [Display(Name = "Sermon Image")]
        public string Image { get; set; }

        [Display(Name = "Category Type")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
