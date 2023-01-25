namespace Application.UnitTests;

public class SearchTests
{
    [Fact]
    public void When_Entering_Search_Input_Return_List_Of_Groceries()
    {
        // Arrange
        var category = "Banan";
        var groceriesClient = new HttpClient();
        var cards = new List<Card>()
        {
            new Card() // kött
            new Card() //äpple
            new Card() // Bannan
            new Card() // mango
            new Card() // mjölk
        };

        var response = groceriesClient.getAsync(any.string).ReturnsForAnyArgs(any.string);
        var responceContent = response.Content.ReadAsStringAsync().ReturnsForAnyArgs(any.string);
        var allacard = JsonConvert.DeserializeObject<List<Card>>(responceContent).ReturnsForAnyArgs(cards);






        var expected = new List<Grocery>
        {
            new Grocery { Name = "Banan", Price = 1.99m },
            new Grocery { Name = "Banan Ekologisk", Price = 2.99m }
            new


        };



        // Act
        var actual = fetchdata.GetApiInfo(category);

        // Assert
        Assert.Equal(expected, actual);

    }
}
