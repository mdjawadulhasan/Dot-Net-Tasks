using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NtierBLL.DTO
{
    public class NewsDTO
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public Nullable<int> CatId { get; set; }
        [Required]
        public Nullable<System.DateTime> Date { get; set; }
    }
}
