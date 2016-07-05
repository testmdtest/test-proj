using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Git2.Models
{
    public class ComicBook
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Issue { get; set; }
        public string DescripHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Fav { get; set; }
    

        public string Display
        {
            get
            {
                return Title + " #: " + Issue;
            }

        }

        public string CoverImgFileNm
        {
            get
            {
                return Title.Replace(" ", "-").ToLower() + "-" + Issue + ".jpg";
            }
        }

    }
}