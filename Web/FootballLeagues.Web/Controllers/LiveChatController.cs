﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballLeagues.Web.Controllers
{
    [Authorize]
    public class LiveChatController : Controller
    {
        //
        // GET: /LiveChat/
        public ActionResult Index()
        {
            return View();
        }
    }
}