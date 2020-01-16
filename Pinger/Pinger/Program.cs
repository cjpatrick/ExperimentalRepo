using System;
using System.Net.NetworkInformation;

namespace Pinger
{
  class Program
  {
    static void Main(string[] args)
    {
      bool success = Ping("10.0.1.151");
      if (success)
      {
        Console.Write("Success");
      }
      else
      {
        Console.WriteLine("Failure");
      }
    }

    public static bool Ping(string ip)
    {
      int timeout = 10;

      Ping p = new Ping();
      PingReply rep = p.Send(ip, timeout);

      if (rep.Status == IPStatus.Success)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
