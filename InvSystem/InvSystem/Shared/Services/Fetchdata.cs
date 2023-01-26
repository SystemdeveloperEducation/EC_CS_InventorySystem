using Newtonsoft.Json;
using InvSystem.Data;
using System.IO;

namespace InvSystem.Shared.Services
{
    public class Fetchdata
    {
        public static async Task<List<Card>> GetApiInfo(string category)
        {
            var cards = new List<Card>();
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5000/api/groceries");
            var cardsJson = await response.Content.ReadAsStringAsync();
            var allCards = JsonConvert.DeserializeObject<List<Card>>(cardsJson);
            cards = allCards.Where(c => c.Category == category).ToList();
            return cards;
        }
    }
}
