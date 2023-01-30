using System.IO;
using InvSystem.Data;
using Newtonsoft.Json;

namespace InvSystem.Shared.Services
{
    public class Fetchdata
    {
        public List<Card> Cards { get; set; } = new List<Card>();
        public static async Task<List<Card>> GetApiInfo()
        {
            var client = new HttpClient();
            var response = await client.GetAsync("http://localhost:5000/api/groceries");
            var cardsJson = await response.Content.ReadAsStringAsync();
            var allCards = JsonConvert.DeserializeObject<List<Card>>(cardsJson);
            return allCards is null ? throw new Exception("No cards found") : allCards;
        }


        public static List<Card> GetCategoriesCards(string category, List<Card> allCards)
        {
            var cards = allCards.Where(c => c.Category == category).ToList();
            return cards;
        }
    }
}
