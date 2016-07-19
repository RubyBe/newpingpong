using System.Collections;
using System.Collections.Generic;


namespace PingPong.Objects
{

  // A class that generates a list of numbers and then replaces certain numbers with strings
  public class PingPongGenerator
  {
    // properties
    private int _topNumber; // holds number input by user
    private int[] _numberArray;   // holds an array which will be generated based on the int which was parsed
    private ArrayList _listArray = new ArrayList(); // holds an Arraylist of strings and integers which will take values from the array, with certain numbers replaced by strings; We can also do this using a dictionary of keys = Ints, values = Strings
    private string _forThrees; // holds replacement string for multiples of threes
    private string _forFives; // holds replacement string for multiples of fives
    private string _forThreeFives; // holds replacement string for multiples of both three and five

    // constructors, getters and setters
    // a constructor which takes one parameter
    public PingPongGenerator(int topNumber)
    {
      _topNumber = topNumber;
    }

    public int GetPingPongGeneratorTop()
    {
      return _topNumber;
    }

    public void SetPingPongGeneratorTop(int topNumber)
    {
     _topNumber = topNumber;
    }

    // other methods
    // A method to generate an array of numbers based on an int that has been passed in
    public int[] CreateNumberArray(int topnumber)
    {
      int[] _numberArray = new int[topnumber];
      for (int i = 0; i < topnumber; i++)
      {
        _numberArray[i] = i + 1;
      }
      return _numberArray;
    }

    // A method to insert the string "ping" when given a number which is a multiple of 3
    public ArrayList ReplaceThrees(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 3 == 0)
        {
          _listArray.Add("ping");
        }
        else
        {
          _listArray.Add(i + 1);
        }
      }
      return _listArray;
    }

    // A method to insert the string "pong" when given a number which is a multiple of 5
    public ArrayList ReplaceFives(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 5 == 0)
        {
          _listArray.Add("pong");
        }
        else
        {
          _listArray.Add(i + 1);
        }
      }
      return _listArray;
    }

    // A method to insert the string "ping-pong" when given a number which is a multiple of both 5 and 10
    public ArrayList ReplaceThreeFives(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] % 15 == 0)
        {
          _listArray.Add("ping-pong");
        }
        else if (array[i] % 5 == 0)
        {
          _listArray.Add("pong");
        }
        else if (array[i] % 3 == 0)
        {
          _listArray.Add("ping");
        }
        else
        {
          _listArray.Add(i + 1);
        }
      }
      return _listArray;
    }
  }
}
