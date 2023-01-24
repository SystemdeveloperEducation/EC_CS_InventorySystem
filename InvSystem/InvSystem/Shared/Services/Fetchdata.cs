using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using InvSystem.Data;
using InvSystem.Shared;

namespace InvSystem.Shared.Services
{
    public class Fetchdata
    {

        public static Card async Task GetApiInfo(string category)
        {
            var cards = new List<Card>();
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5000/api/groceries");
            var cardsJson = await response.Content.ReadAsStringAsync();
            var allCards = JsonConvert.DeserializeObject<List<Card>>(cardsJson);
            cards = allCards.Where(c => c.Category == category).ToList();

        }

    }
}