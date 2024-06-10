using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTQlesson08K22CNT2.Models
{
    public class PtqCategory
    {
        [Key]
        public int PtqCategoryId { get; set; }
        public string PtqCategoryName { get; set; }
        //thuộc tính quan hệ
        public virtual ICollection<PtqBook> PtqBook { get; set; }
    }
}