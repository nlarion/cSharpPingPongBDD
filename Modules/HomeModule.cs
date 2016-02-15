using Nancy;
using System.Collections.Generic;

namespace PingPong
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
          return View["index.cshtml"];
      };
      Post["/"] = _ => {
        PPG.ClearAll();
        PPG ppg = new PPG(int.Parse(Request.Form["userNumber"]));
        List<string> userList = ppg.GetAll();
        return View["index.cshtml",userList];
      };
    }
  }
}
