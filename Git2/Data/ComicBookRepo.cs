using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Git2.Models
{
    public class ComicBookRepo
    {
        // REPO PATTERN
            private static ComicBook[] _comics=new ComicBook[]
            {
                 new ComicBook()
                    {
                        Title = "Bone",
                        Issue = 50,
                        DescripHtml = "<p>Some info re this issue</p>",
                        Artists = new Artist[]
                        {
                            new Artist(){Name="Bob", Role="Draw"},
                            new Artist() {Name="joe", Role="Write"}
                        }
                    },
                    new ComicBook()
                    {
                        Title = "The Amazing Spider Man",
                        Issue = 657,
                        DescripHtml = "<p>Some info re this issue</p>",
                        Artists = new Artist[]
                        {
                            new Artist(){Name="Bob", Role="Draw"},
                            new Artist() {Name="joe", Role="Write"}
                        }
                    },
                    new ComicBook()
                    {
                        Title = "The Amazing Spider Man",
                        Issue = 700,
                        DescripHtml = "<p>Some info re this issue</p>",
                        Artists = new Artist[]
                        {
                            new Artist(){Name="Bob", Role="Draw"},
                            new Artist() {Name="joe", Role="Write"}
                        }
                    }
            };

        //note EF uses ICOleect
        public ComicBook[] GetComics()
            {
                return _comics;
            }
       
            public ComicBook getComicBook(int id)
            {
                ComicBook comic=null;

                foreach (var item in _comics)
	            {
                    if (item.Id==id)
                    {
                        comic = item;
                        break;
                        //or just return
                    }         
	            }

             return comic;
            }
    }
}