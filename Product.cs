using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace App
{
    internal class Product
    {
        public string name { get; set; 
        }
        public int price {  get; set; }
        public bool in_stock {  get; set; }
        public Product(String name, int price, bool in_stock){
            this.name = name;
            this.price = price;
            this.in_stock = in_stock;
        }

        public override string ToString()
        {
            string stockStatus = in_stock ? "Készleten" : "Nincs készleten";
            return $"Termék: {name}, Ár: {price} USD, Állapot: {stockStatus}";
        }

    }
}
