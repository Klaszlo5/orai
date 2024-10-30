using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Net.Http.Headers;
using System.Text.Json;

namespace App
{
    internal class Inventory
    {
        public HashSet<Product> products;
        public Inventory()
        {
            this.products = [];
        }


        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine(string.Format("A(z) {0} termék sikeresen hozzáadva.", product.name));
        }
        public void RemoveProduct(string product)
        {
            foreach (Product p in products)
            {
                if (p.name == product)
                {
                    this.products.Remove(p);
                    Console.WriteLine(string.Format("A(z) {0} termék sikeresen törölve.", product));
                    return;
                }
            }
            Console.WriteLine(string.Format("A(z) {0} termék nem található.", product));
        }

        public Product FindProduct(string product)
        {
            foreach (Product p in products)
            {
                if (p.name == product)
                {
                    this.products.Remove(p);
                    return p;
                }
            }
            Console.WriteLine(string.Format("A(z) {0} termék nem található.", product));
            return null;
        }

        public void ListProducts()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Nincsenek termékek a készletben.");
            }
            else
            {
                foreach (Product product in products)
                {
                    Console.WriteLine(product);
                }
            }

        }
        public void SaveToFile(string path)
        {
            try
            {
                var jsonData = JsonSerializer.Serialize(products);
                File.WriteAllText(path, jsonData);
                Console.WriteLine($"Termékek sikeresen mentve ide: {path}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba a termékek mentésekor: {e.Message}");
            }
        }

        public void LoadFromFile(string path)
        {
            try
            {
                var jsonData = File.ReadAllText(path);
                products = JsonSerializer.Deserialize<HashSet<Product>>(jsonData);
                Console.WriteLine($"Termékek sikeresen betöltve innen: {path}.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Hiba a termékek betöltésekor: {e.Message}");
            }
        }
    }
    }
