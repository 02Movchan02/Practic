using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace ControllersAndAction.Controllers
{
    public class ExampleController : Controller
    {
        public StatusCodeResult Index() => NotFound();
    }
}