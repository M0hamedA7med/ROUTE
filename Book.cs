using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }
        public override string ToString()
        {
            return $"Book Title: {Title}, Pages: {Pages}";
        }
    }
}
