using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comic_book_gallery.Models;

namespace comic_book_gallery.Data
{
    public class ComicBookRepository
    {
        private static ComicBook[] _comicBooks = new ComicBook[]
        {
               new ComicBook()
                {
                Id = 1,
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

                 },
                Favorite = false
                 },
                new ComicBook()
                {
                 Id = 2,
                SeriesTitle = "The Amazing Spider-Man",
                IssueNumber = 657,
                DescriptionHtml = "<p>Three Tie In",
                Artists = new Artist[]
                    {
                    new Artist() { Name = "Dan SLott", Role = "Script"},
                    new Artist() { Name = " Humberto Ramos", Role = "Pencils"},
                    new Artist() { Name = "Victor Olazaba", Role = "Inks"},
                    new Artist() { Name = "Edgar Delgado", Role = "Colors"},
                    new Artist() { Name = "Chriss Ellipoulos", Role = "Letters"},

                    },
                Favorite = false
                    },
                  new ComicBook()
                  {
                    Id = 3,
                    SeriesTitle = "Bones",
                    IssueNumber = 50,
                    DescriptionHtml = "The Dungeon and Parapet",
                    Artists = new Artist[]
                     {
                        new Artist() { Name = "Jeff Smith", Role = "Script"},
                        new Artist() { Name = "Jeff Smith", Role = "Pencils"},
                        new Artist() { Name = "Jeff Smith", Role = "Inks"},
                        new Artist() { Name = "Jeff Smith", Role = "Colors"},
                        new Artist() { Name = "Jeff Smith", Role = "Letters"},

                     },
                    Favorite = false
                  },
    };
        public ComicBook GetComicBook(int id)
        {
            ComicBook comicBookToReturn = null;
            foreach (var comicBook in _comicBooks)
            {
                if(comicBook.Id == id)
                {
                    comicBookToReturn = comicBook;

                    break;
                }
            }
            return comicBookToReturn;
        }
    }
}