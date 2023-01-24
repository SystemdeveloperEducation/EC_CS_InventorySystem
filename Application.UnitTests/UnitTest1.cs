namespace Application.UnitTests;

public class SearchTests
{
    [Fact]
    public void When_Entering_Search_Input_Return_List_Of_Groceries()
    {
        // Arrange
        var searchInput = "Banan";
        var expected = new List<Grocery>
        {
            new Grocery { Name = "Banan", Price = 1.99m },
            new Grocery { Name = "Banan Ekologisk", Price = 2.99m }
        };

       

        // Act
        var actual = searchService.Search(searchInput);

        // Assert
        Assert.Equal(expected, actual);
    
    }
}