﻿namespace Autenticacion.DataService.Models
{
    public class Comment : BaseEntity
    {
        public string Body { get; set; }
        public string UserId { get; set; }
        public string PostId { get; set; }
        public Post Post { get; set; }
    }
}
