﻿using Microsoft.AspNetCore.Mvc;

namespace AppPrivy.WebAppSiteBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
