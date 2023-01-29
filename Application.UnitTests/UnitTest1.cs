using System;
using System.Collections.Generic;
using InvSystem.Data;
using InvSystem.Shared.Services;
using Moq;
using Newtonsoft.Json;
using Xunit;

namespace Application.UnitTests;

public class FetchDataTests
{
    [Fact]
    public void When_Entering_Search_Input_Return_List_Of_Groceries()
    {
        // Arrange
        var category = "Frukt";
        var cards = new List<Card>()
        {
            new Card{ Title = "Banan", Category = "Frukt" },// kött
            new Card{ Title = "Mango", Category = "Frukt" },
            new Card{ Title = "Fransyska av nöt", Category = "Kött & Chark" },
            new Card{ Title = "Mjölk", Category = "Mejeri" },
            new Card{ Title = "Röd Paprika", Category = "Grönsaker" },
            new Card{ Title = "Fläskfärs", Category = "Kött & Chark" },
        };

        var expected = new List<Card>
        {
            new Card { Title = "Banan", Category = "Frukt" },
            new Card { Title = "Mango", Category = "Frukt" }
        };



        // Act
        var actual = Fetchdata.GetCategoriesCards(category, cards);

        // Assert
        Assert.Equivalent(expected, actual);

    }

    // [Fact]
    // public void When_Entering_Search_Input_Return_List_Of_Groceries2()
    // {
    //     // Arrange
    //     var category = "Frukt";
    //     var groceriesClient = new HttpClient();
    //     var cards = new List<Card>()
    //     {
    //         new Card{ Title = "Banan", Category = "Frukt" },// kött
    //         new Card{ Title = "Mango", Category = "Frukt" },
    //         new Card{ Title = "Fransyska av nöt", Category = "Kött & Chark" },
    //         new Card{ Title = "Mjölk", Category = "Mejeri" },
    //         new Card{ Title = "Röd Paprika", Category = "Grönsaker" },
    //         new Card{ Title = "Fläskfärs", Category = "Kött &" },
    //     };

    //     var response = groceriesClient.getAsync(It.IsAny<string>()).ReturnsForAnyArgs(It.IsAny<string>());
    //     var responseContent = response.Content.ReadAsStringAsync().ReturnsForAnyArgs(It.IsAny<string>());
    //     var allacard = JsonConvert.DeserializeObject<List<Card>>(responseContent).ReturnsForAnyArgs(cards);






    //     var expected = new List<Grocery>
    //     {
    //         new Grocery { Title = "Banan", Category = "Frukt" },
    //         new Grocery { Name = "Mango", Price = "Frukt" }
    //     };



    //     // Act
    //     var actual = fetchdata.GetApiInfo(category);

    //     // Assert
    //     Assert.Equal(expected, actual);

    // }


}



