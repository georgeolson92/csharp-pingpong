using System.Collections.Generic;
using System;
using Xunit;
namespace PingPongGenerator
{
  public class PingPongGeneratorTest
  {
    [Fact]
    public void PingPongMaker_ForNumberDivisibleByThree_ReturnList()
    {
      //Arrange
      List<string> expectedResult = new List<string> {"1", "2", "Ping"};
      PingPongGenerator testPingPongGenerator = new PingPongGenerator();

      //Act
      List<string> result = testPingPongGenerator.PingPongMaker(3);

      //Assert
      Assert.Equal(result, expectedResult);
    }
  }
}
