using System;

namespace Lab11
{
    public class Drama : IMovie
    {
        private string _title;
        private string _category;

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a value");
                }
                _title = value;
            }
        }
        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Please enter a value");
                }
                _category = value;

            }
        }
        public Drama(string title)
        {
            Title = title;
            Category = "Drama";
        }

    }
}