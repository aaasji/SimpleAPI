using SimpleAPI;
namespace SimpleAPI.Tests;

public class UnitTest1
{
    ValuesController valuesController = new ValuesController();//Arrange
    [Fact]
    public void Test1()
    {

    }
    [Fact]
    public void GetReturnedCollectionNumber()
    {
    var get_value = valuesController.Get(1);
    Assert.Equal("AshishArora",get_value);
    Assert.NotNull(get_value);
    //given 
    //when  
    // then
    }
}