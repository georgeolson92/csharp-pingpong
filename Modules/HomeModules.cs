using Nancy;
using System.Collections.Generic;
using PingPongGenerator.Objects;

namespace PingPongGenerator {

  public class HomeModule : NancyModule {

    public HomeModule()
    {
      Get["/"] = _ => {
      return View["index.cshtml"];
      };
      Get["/results"] = _ => {
      PingPongList userPingPongList = new PingPongList(int.Parse(Request.Query["user-input"]));

      return View["results.cshtml", userPingPongList];
      };
    }

  }

}
