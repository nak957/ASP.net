using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PTQlesson08K22CNT2.Models
{
    public class PtqBook
    {
        [Key]
        public int PtqBookId { get; set; }
        public string PtqTitle { get; set; }
        public string PtqAuthor { get; set; }
        public int PtqYear { get; set; }
        public string Ptqpubliser { get; set; }
        public string PtqPicture { get; set; }
        public int PtqCategoryId { get; set; }
        //thuộc tính quan hệ
        public virtual PtqCategory PtqCategory { get; set; }
    }
}