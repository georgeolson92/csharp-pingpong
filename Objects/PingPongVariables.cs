using System.Collections.Generic;
using System;

namespace PingPongGenerator.Objects
{
  public class PingPongList
  {
    private List<string> _result;

    public PingPongList(int countingNumber)
    {
      PingPongMaker(countingNumber);
    }

    public List<string> GetResults()
    {
      return _result;
    }

    public void PingPongMaker(int countingNumber)
    {
      List<string> pingPongList = new List<string> {};
      for (int i=1; i <= countingNumber; i ++)
      {
        string stringToAdd = "";
        if (i % 15 == 0)
        {
          stringToAdd = "PingPong";
        }
        else if (i % 5 == 0)
        {
          stringToAdd = "Pong";
        }
        else if (i % 3 == 0)
        {
          stringToAdd = "Ping";
        }
        else
        {
          stringToAdd = i.ToString();
        }
        pingPongList.Add(stringToAdd);
      }
      _result = pingPongList;
    }
  }
}
