using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BarManager.Models
{
    public class Item
    {

        public Item(String name, int ammount)
        {
            this.id = counter++;
            this.name = name;
            this.ammount = ammount;
        }

        static int counter = 0;
        public int id { get; set; }
        public String name { get; set; }
        public int ammount { get; set; }
    }
}