using System;
using System.Collections.Generic;

namespace m2
{
    public class Author
    {
        public string Name { get; set; }
        public string[] Courses { get; set; }
        public DateTime Since { get; set; }
        public bool Happy { get; set; }
        public object Issues { get; set; }
        public Car Car { get; set; }
        public List<Author> FavoriteAuthors { get; set; }
        public AuthorRelationship AuthorRelationship { get; set; }
    }
}
