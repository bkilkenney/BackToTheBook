using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Book
    {

        private string title;
        private string author;
        private int pages;
        private int wordCount;

        public Book(string title)
        {
            this.title = title;
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }
        

        public int WordCount
        {
            get { return wordCount; }
            set { wordCount = value; }
        }

        //Methods


        public string GetTitle()
        {
            return title;
        }


        public void SetTitle()
        {
            this.Title = title;
        }


        public void AssignWordCountFromText(string text)
        {
            wordCount = text.Split(' ').Length;
        }

    }
}
