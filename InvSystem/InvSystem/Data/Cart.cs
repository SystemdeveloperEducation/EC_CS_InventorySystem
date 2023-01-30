using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static InvSystem.Data.Card;

namespace InvSystem.Data
{
    public class Cart : Card
    {

        private static List<Card> _products;

        public Cart()
        {
            _products = new List<Card>();
        }

        public void AddProductToCart(Card product)
        {
            _products.Add(product);
            Console.WriteLine("This is the product in the cart " + _products.Count);
        }


        public void RemoveProduct(Card product)
        {
            _products.Remove(product);
        }

        public List<Card> GetProducts()
        {
            Console.WriteLine("These are the products in the GetProducts" + _products.Count);
            return _products;
        }

    }

}