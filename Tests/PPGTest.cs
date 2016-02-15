using Xunit;
using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PPGTest : IDisposable
  {
    [Fact]
    public void Test1ReturnAListOfPingsAndPongs()
    {
      //Arrange
      int userInt = 7;
      PPG ppg = new PPG(userInt);
      List<string> userList = ppg.GetAll();

      //Act
      List<string> testList = new List<string>{"1", "2", "ping", "4", "pong", "ping", "7"};

      //Assert
      Assert.Equal(testList, userList);
    }
    public void Dispose()
    {
      PPG.ClearAll();
    }
  }
}
