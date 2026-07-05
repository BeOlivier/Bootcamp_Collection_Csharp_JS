using System;

namespace Kanye.API
{
    public class KanyeQuotePostRequest
    {
        public Guid Id { get; set; }
        public DateTime CommentedAt { get; set; }
        public string Comment { get; set; }
        public string UserName { get; set; } 
    }
}