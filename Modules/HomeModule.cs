using Nancy;
using System.Collections.Generic;
using Namespace.Objects;


namespace Namespace
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
