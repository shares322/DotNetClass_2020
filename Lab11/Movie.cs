using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11
{
     public interface IMovie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public void Genre();
        //public string Genre { get; set; }
        //public Movie()
        //{
        //    Console.WriteLine(Genre);
        //}

        //    private string _title;
        //    private string _category;

        //    public string Title
        //    {
        //        get
        //        {
        //            return _title;
        //        }
        //        set
        //        {
        //            this._title = value;
        //        }
        //    }
        //    public string Category
        //    {
        //        get
        //        {
        //            return _category;
        //        }
        //        set
        //        {
        //            this._category = value;
        //        }
        //    }
        //public void Genre()
        //{
        //    Title = title;
        //    Category = Category;
        //}
        //}
    }
}


