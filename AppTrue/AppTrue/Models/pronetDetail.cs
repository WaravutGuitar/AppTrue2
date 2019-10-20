using System;
using System.Collections.Generic;
using System.Text;

namespace AppTrue.Models
{
    public class pronetDetail
    {
        public int active { get; set; }
        public string _id { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public Category2 category { get; set; }
        public int pricing { get; set; }
        public string tel { get; set; }
        public long created_at { get; set; }
        public long update_at { get; set; }
        public int __v { get; set; }
    }
    public class Category2
    {
        public int active { get; set; }
        public string _id { get; set; }
        public string title { get; set; }
        public long created_at { get; set; }
        public long update_at { get; set; }
        public int __v { get; set; }
        public string type { get; set; }
    }
}
