using System;

namespace Kanye.API
{
    public class QuoteResponse
    {
        //dt
        public DateTime RequestedAt { get; set; }

        //quote itself
        public KanyeQuote Quote { get; set; }

        //unique guid
        public Guid Id { get; set; }

        public QuoteResponse(DateTime now, KanyeQuote qt, Guid id)
        {
            RequestedAt = now;
            Quote = qt;
            Id = id;
        }
    }
}