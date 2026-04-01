using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backery
{
    public class ProductClass
    {
        public int id { get; set; }
        public string name { get; set; } = string.Empty;
        public string picture_key { get; set; } = string.Empty;
        public double price { get; set; }
        public string content { get; set; } = string.Empty;
        public int category_id { get; set; }
        public string category { get; set; } = string.Empty;
    }
}
