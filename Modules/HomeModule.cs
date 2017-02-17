using Nancy;
using System;
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
            Post["/wordcount"] = _ => {
                RepeatCounter newInput = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
                return View["wordcount.cshtml", newInput];
            };
        }
    }
}
