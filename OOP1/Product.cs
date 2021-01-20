using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product   // Product = Ürün
    {
        public int Id { get; set; }             //ana anahtar
        public int CategoryId { get; set; }     //referans anahtar 
        public string ProductName { get; set; } //Ürün adı
        public double UnitPrice { get; set; }   //Birim fiyatı

        public int UnitInStock { get; set; }    //stok adedi
    }
}
