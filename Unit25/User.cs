﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Unit25
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        public List<Book> Books { get; set; } = new List<Book>();
    }
}
