using System;

namespace Fisher.Bookstore.Api.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Intro { get; set; }
        public DateTime DOB { get; set; }
    }
}