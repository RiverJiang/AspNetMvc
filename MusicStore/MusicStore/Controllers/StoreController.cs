﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre{ Name ="Disco"},
                new Genre{ Name ="Jazz" },
                new Genre{ Name = "Rock"}
            };

            return View(genres);
        }

        //
        // GET: /Store/

        public ActionResult Browse()
        {
            var genreModel = new Genre { Name = "genre" };

            return View(genreModel);
        }

        //
        // GET: /Store/

        public ActionResult Details(string id)
        {
            var album = new Album { Title = "Album" + id };

            return View(album);
        }
    }
}
