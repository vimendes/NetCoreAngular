﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace booksapi.Models
{
    public class Category : Entity
    {

        [Required(ErrorMessage = "The 'title' field is required")]
        [MinLength(3, ErrorMessage = "The 'title' field is too short.")]
        [MaxLength(150, ErrorMessage = "The 'title' field is too long.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The 'code' field is required")]
        [MinLength(3, ErrorMessage = "The 'code' field is too short.")]
        [MaxLength(100, ErrorMessage = "The 'code' field is too long.")]
        public string UrlCode { get; set; }

        public List<Book> Books { get; set; }
    }
}
