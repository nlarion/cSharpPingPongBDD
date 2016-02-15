using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PPG
  {
    private int _userNumber;
    private int _id;
    private static List<string> _instances = new List<string> {};

    public PPG(int userNumber)
    {
      _userNumber = userNumber;
      for(int i = 1; i<=userNumber; i++)
      {
        if (i % 15 == 0)
        {
          _instances.Add("ping-pong");
        }
        else if (i % 5 == 0)
        {
          _instances.Add("pong");
        }
        else if (i % 3 == 0)
        {
          _instances.Add("ping");
        }
        else
        {
          _instances.Add(i.ToString());
        }
      }
    }
    public List<string> GetAll()
    {
        return _instances;
    }
    public static void ClearAll()
    {
       _instances.Clear();
    }
  }
}
