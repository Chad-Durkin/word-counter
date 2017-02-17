using Nancy;
using System.Collections.Generic;
using RepeatCounterApp.Objects;


namespace RepeatCounterApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ => {
                return View["index.cshtml"];
            };
        }
    }
}
