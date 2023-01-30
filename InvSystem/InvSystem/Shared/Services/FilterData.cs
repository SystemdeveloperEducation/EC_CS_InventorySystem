using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvSystem.Data;


namespace InvSystem.Shared.Services
{
    public class FilterData
    {
        private static List<Card> cards = new List<Card>();
        public static List<Card> ProductsFiltered(string category, List<Card> allCards)
        {
            cards = allCards.Where(c => c.Category == category).ToList();
            return cards;
        }
    }
}
