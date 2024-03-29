﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingCart.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public partial class Genre
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Album> Albums { get; set; }
    }
}