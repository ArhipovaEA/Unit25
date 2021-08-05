using System;
using System.Collections.Generic;
using System.Text;

namespace Unit25
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string Avtor { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string Genre { get; set; }
    }
}
