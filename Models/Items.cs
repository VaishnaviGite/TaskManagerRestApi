﻿using System.ComponentModel.DataAnnotations;

namespace TaskManagerRestApi.Models
{
    public class Items
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Description { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsComplete { get; set; }
    }
}
