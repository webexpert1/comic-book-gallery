using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comic_book_gallery.Controllers
{
    public class ComicBooksController: Controller
    {
        public ActionResult Detail()
        {
           ViewBag.SeriesTitle = "The Amazing Spider-Man";
           ViewBag.IssueNumber = 700;
           ViewBag.Description = "<p>Final issue! Witness the final hour";
           ViewBag.Artists = new string[]
            {
                "Script: Dan SLott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chriss Ellipoulos"
            };
            return View();           
            
        }
    }
}