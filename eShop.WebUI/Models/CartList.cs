using eShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.WebUI.Models
{
    public class CartList
    {
        public List<CartLine> List { get; set; } = new List<CartLine>();
        //Sessionda saklayacağımız için public yaptık.
        public void AddToCart(Product product, int quantity)
        {
            var existingProduct = List.FirstOrDefault(x => x.Product.Id == product.Id);
            if (existingProduct == null)
            {
                List.Add(new CartLine { Product = product, Quantity = quantity });
            }
            else
            {
                existingProduct.Quantity += quantity;
            }
        }

        public decimal TotalPrice()
        {
            return List.Sum(t => t.Product.Price * t.Quantity);
        }
        public void Clear()
        {
            List.Clear();
        }
        public void Delete(Product product)
        {
            List.RemoveAll(x => x.Product.Id == product.Id);
        }


    }
}
