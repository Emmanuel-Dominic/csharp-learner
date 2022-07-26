using System;

namespace Classes.Defining
{
    // Classes have a name unique with the namespace
    /// <summary>
    /// Represents a book with title, author, published, and page count.
    /// </summary>
    public class Book
    {
        // classes have member variables or "fields" to hold data
        string _name;
        /// <summary>
        /// Flag indicating whether the book is published.
        /// </summary>
        public bool _published;
        /// <summary>
        /// The author of the book.
        /// </summary>
        protected string _author;
        private int _pageCount;

        // classes have one or more contructors
        /// <summary>
        /// Initializes a new instance of the Book class.
        /// </summary>
        /// <param name="name">The title of the book.</param>
        /// <param name="published">The published status of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="pages">The number of pages in the book.</param>
        public Book(string name, string author, int pages, bool published) {
            _name = name;
            _author = author;
            _published = published;
            _pageCount = pages;
        }

        // methods are used to operate on the class and data
        /// <summary>
        /// Gets a brief description of the book.
        /// </summary>
        /// <returns>A string containing the book's title and author.</returns>
        public string GetDescription() {
            return $"{_name} by {_author}";
        }

        // Member variabes can be accessed via methods
        /// <summary>
        /// Gets the book's name.
        /// </summary>
        /// <returns>The book's name.</returns>
        public string GetName() 
        {
            return _name;
        }

        /// <summary>
        /// Sets the book's name.
        /// </summary>
        /// <param name="name">The new name for the book.</param>
        public void setName(string name) 
        {
            _name = name;
        }

        /// <summary>
        /// Gets the book's author.
        /// </summary>
        /// <returns>The book's author.</returns>
        public string GetAuthor() 
        {
            return _author;
        }

        /// <summary>
        /// Sets the book's author.
        /// </summary>
        /// <param name="author">The new author for the book.</param>
        public void setAuthor(string author) 
        {
            _author = author;
        }

        /// <summary>
        /// Gets the book's page count.
        /// </summary>
        /// <returns>The book's page count.</returns>
        public int GetPageCount() 
        {
            return _pageCount;
        }

        /// <summary>
        /// Sets the book's page count.
        /// </summary>
        /// <param name="pages">The new page count for the book.</param>
        public void setPageCount(int pages) 
        {
            _pageCount = pages;
        }
    }
}
