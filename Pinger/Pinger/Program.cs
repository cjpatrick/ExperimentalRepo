using System;

namespace Pinger
{
  class Program
  {
    static void Main(string[] args)
    {
      bool success = Ping();
      if (success)
      {
        Console.Write("Success");
      }
    }

    public static bool Ping()
    {
      return true;
    }
  }
}
