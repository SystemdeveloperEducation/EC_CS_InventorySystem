using InvSystem.Data;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Xunit;
using Moq;

namespace Application.UnitTests;

public class FetchDataTests
{
    // [Fact]
    // public void When_Entering_Search_Input_Return_List_Of_Groceries()
    // {
    //     // Arrange
    //     var category = "Frukt";
    //     var mockHandler = new Mock<HttpMessageHandler>();
    //     var groceriesClient = new HttpClient(mockHandler.Object);
    //     // var groceriesClient = new Mock<HttpClient>();
    //     var cards = new List<Card>()
    //     {
    //         new Card{ Title = "Banan", Category = "Frukt" },// kött
    //         new Card{ Title = "Mango", Category = "Frukt" },
    //         new Card{ Title = "Fransyska av nöt", Category = "Kött & Chark" },
    //         new Card{ Title = "Mjölk", Category = "Mejeri" },
    //         new Card{ Title = "Röd Paprika", Category = "Grönsaker" },
    //         new Card{ Title = "Fläskfärs", Category = "Kött & Chark" },
    //     };

    //     // groceriesClient.Setup(x => x.GetAsync(It.IsAny<string>())).ReturnsAsync(It.IsAny<string>());
    //     var result = new HttpResponseMessage(HttpStatusCode.OK)
    //     {
    //         Content = new StringContent(JsonConvert.SerializeObject(cards))
    //     };
    //     //var response = groceriesClient.GetAsync(It.IsAny<string>()).Returns(It.IsAny<string>());
    //     // groceriesClient.Setup(x => x.Content.ReadAsStringAsync()).ReturnsAsync(It.IsAny<string>());
    //     //var responseContent = g.Content.ReadAsStringAsync().Returns(It.IsAny<string>());
    //     //var allacard = JsonConvert.DeserializeObject<List<Card>>(groceriesClient).Returns(cards);






    //     var expected = new List<Card>
    //     {
    //         new Card { Title = "Banan", Category = "Frukt" },
    //         new Card { Title = "Mango", Category = "Frukt" }
    //     };



    //     // Act
    //     var actual = fetchdata.GetApiInfo(category);

    //     // Assert
    //     Assert.Equal(expected, actual);

    // }

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



