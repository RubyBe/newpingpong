using PingPong.Objects;
using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;

namespace PingPong
{
  public class PingPongGeneratorTest
  {
    [Fact]
    // it can accept a number from a player
    public void AcceptsNumber_SetsNumber_NumberIsSet()
    {
      // Arrange
      int testNumber = 3;

      // Act
      PingPongGenerator myGenerator = new PingPongGenerator(testNumber);
      int result = myGenerator.GetPingPongGeneratorTop();

      // Assert
      // Expected number is first, actual is second
      Assert.Equal(testNumber, result);
    }

    [Fact]
    // it can generate a list of numbers from 1 through the number accepted from the player
    public void GenerateNumberArray_GeneratesNumberArray_NumberArrayCreated()
    {
      // Arrange
      int topNumber = 5;
      int[] testArray = new int[5];
      testArray[0] = 1;
      testArray[1] = 2;
      testArray[2] = 3;
      testArray[3] = 4;
      testArray[4] = 5;


      // Act
      PingPongGenerator newGenerator = new PingPongGenerator(topNumber);
      int[] newArray = newGenerator.CreateNumberArray(topNumber);

      // Assert
      Assert.Equal(testArray, newArray);
    }

    [Fact]
    // it can replace multiples of 3 with the string "ping"
    public void ReplaceThrees_ReplacesThreesWithPing_ThreeIsPing()
    {
      // Arrange
      int nextNumber = 3;
      ArrayList testThreesList = new ArrayList();
      testThreesList.Add(1);
      testThreesList.Add(2);
      testThreesList.Add("ping");
      int[] testArray = new int[3];
      testArray[0] = 1;
      testArray[1] = 2;
      testArray[2] = 3;

      // Act
      PingPongGenerator newGenerator = new PingPongGenerator(nextNumber);
      ArrayList resultThreesList = newGenerator.ReplaceThrees(testArray);

      // Assert
      Assert.Equal(testThreesList, resultThreesList);
    }

    [Fact]
    // it can replace multiples of 5 with the string "pong"
    public void ReplaceFives_ReplacesFivesWithPong_FiveIsPong()
    {
      // Arrange
      int nextNumber = 5;
      ArrayList testFivesList = new ArrayList();
      testFivesList.Add(1);
      testFivesList.Add(2);
      testFivesList.Add(3);
      testFivesList.Add(4);
      testFivesList.Add("pong");
      int[] testArray = new int[5];
      testArray[0] = 1;
      testArray[1] = 2;
      testArray[2] = 3;
      testArray[3] = 4;
      testArray[4] = 5;

      // Act
      PingPongGenerator newGenerator = new PingPongGenerator(nextNumber);
      ArrayList resultFivesList = newGenerator.ReplaceFives(testArray);

      // Assert
      Assert.Equal(testFivesList, resultFivesList);
    }

    [Fact]
    // it can replace multiples of both 3 and 5 with the string "ping-pong"
    public void ReplaceThreeFives_ReplacesThreeFivesWithPingPong_ThreeFiveIsPong()
    {
      // Arrange
      int nextNumber = 15;
      ArrayList testThreeFivesList = new ArrayList();
      testThreeFivesList.Add(1);
      testThreeFivesList.Add(2);
      testThreeFivesList.Add("ping");
      testThreeFivesList.Add(4);
      testThreeFivesList.Add("pong");
      testThreeFivesList.Add("ping");
      testThreeFivesList.Add(7);
      testThreeFivesList.Add(8);
      testThreeFivesList.Add("ping");
      testThreeFivesList.Add("pong");
      testThreeFivesList.Add(11);
      testThreeFivesList.Add("ping");
      testThreeFivesList.Add(13);
      testThreeFivesList.Add(14);
      testThreeFivesList.Add("ping-pong");
      int[] testArray = new int[15];
      testArray[0] = 1;
      testArray[1] = 2;
      testArray[2] = 3;
      testArray[3] = 4;
      testArray[4] = 5;
      testArray[5] = 6;
      testArray[6] = 7;
      testArray[7] = 8;
      testArray[8] = 9;
      testArray[9] = 10;
      testArray[10] = 11;
      testArray[11] = 12;
      testArray[12] = 13;
      testArray[13] = 14;
      testArray[14] = 15;

      // Act
      PingPongGenerator newGenerator = new PingPongGenerator(nextNumber);
      ArrayList resultThreeFivesList = newGenerator.ReplaceThreeFives(testArray);

      // Assert
      for (int i = 0; i < 15; i++) { Console.WriteLine(resultThreeFivesList[i]); }
      Assert.Equal(testThreeFivesList, resultThreeFivesList);


    }

  }
}
