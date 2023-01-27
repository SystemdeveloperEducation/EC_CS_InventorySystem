using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvSystem.Data;


namespace InvSystem.Shared.Services
{
    public class FilterData
    {

        public async Task<List<Card>> ProductsFiltered(string category, List<Card> allCards)
        {
            var cards = await allCards.Where(c => c.Category == category).ToList();
            return cards;
        }
    }
}