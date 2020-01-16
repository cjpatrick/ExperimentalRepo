using System;
using System.Net.NetworkInformation;

namespace Pinger
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 0;
      while (i < 256)
      {
        string ip = "10.0.1." + i;
        bool success = Ping(ip);
        if (success)
        {
          Console.Write("IP: " + ip + " pinged successfully \n");
        }
        else
        {
          Console.Write("IP: " + ip + " pinged unsuccessfully \n");
        }
        i++;
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
