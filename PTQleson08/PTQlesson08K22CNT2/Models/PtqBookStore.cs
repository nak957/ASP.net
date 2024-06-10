using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PTQlesson08K22CNT2.Models
{
    public class PtqBookStore:DbContext
    {
        public PtqBookStore() : base("PtqBookStoreConnectionString")
        {

        }
        //tạo các bảng
        public DbSet<PtqCategory> PtqCategories { get; set; }
        public DbSet<PtqBook> PtqBooks { get; set; }
    }
}