﻿using ApiFinShark.Models;

namespace ApiFinShark.Dtos.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime Created { get; set; } = DateTime.Now;

        public int? StockId { get; set; }
    }
}
