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
            System.Console.WriteLine("This is the AddProductToCart: " + _products.Count);
        }


        public void RemoveProduct(Card product)
        {
            _products.Remove(product);
        }

        public List<Card> GetProducts()
        {
            System.Console.WriteLine("This si the GetProducts" + _products.Count);
            return _products;
        }

    }

}
