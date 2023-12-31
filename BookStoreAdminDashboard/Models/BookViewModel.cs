﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreAdminDashboard.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Book Description")]
        public string Description { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Ganre { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]

        public decimal Price { get; set; }
    }
}
