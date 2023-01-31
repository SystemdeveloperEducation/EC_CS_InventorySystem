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
    public void Make_Sure_Given_List_Of_Cards_Is_Correctly_Filtered()
    {
        // Arrange
        var category = "Frukt";
        var cards = new List<Card>()
        {
            new Card{ Title = "Banan", Category = "Frukt" },
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
        var actual = Fetchdata.GetCardsByCategory(category, cards);

        // Assert
        Assert.Equivalent(expected, actual);

    }


}



