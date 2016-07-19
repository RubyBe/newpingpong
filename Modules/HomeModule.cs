using Nancy;
using System;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // Get["/"] =_=>
      // {
      //   Console.WriteLine("Hey Hey Hello from Root");
      //   return View["index.html", myPingPongGenerator];
      // };
    }
  }
}
