using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static InvSystem.Data.Card;

namespace InvSystem.Data
{
    public class Cart : Card
    {

        public static List<Card> _products;

        public Cart()
        {
            _products = new List<Card>();
        }

        public static void AddProductToCart(Card product)
        {
            _products.Add(product);
        }


        public void RemoveProduct(Card product)
        {
            _products.Remove(product);
        }

        public static List<Card> GetProducts()
        {
            return _products;
        }

    }

}
