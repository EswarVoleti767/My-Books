﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBooks.Data.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
