using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gui.models
{
    internal class mod
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public int inventory { get; set; }
        public string objectname { get; set; }
        public int count { get; set; }
        public int price { get; set; }
        public string save()
        {
            int number = this.number;
            DateTime date = this.date;
            int inventory = this.inventory;
            string objectname = this.objectname;
            int count = this.count;
            int price = this.price;
            string all = $"saved:  {objectname} \n  {count} \n {price}";
            return all;

        }
    }
}
