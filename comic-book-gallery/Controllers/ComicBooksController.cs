using comic_book_gallery.Models;
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
            var comicBook = new ComicBook()
            {
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hour",
                Artists = new Artist[]
                 {
                    new Artist() { Name = "Dan SLott", Role = "Script"},
                    new Artist() { Name = " Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chriss Ellipoulos", Role = "Letters"},

                 }
            };
            return View(comicBook);           
            
        }
    }
}