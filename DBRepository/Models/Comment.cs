﻿namespace DBRepository.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostId { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public virtual Post Post { get; set; }
    }
}