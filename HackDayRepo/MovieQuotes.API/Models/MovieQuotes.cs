using System.ComponentModel.DataAnnotations;

namespace MovieQuotes.API;

public class MovieQuotes
{
    [Key]
    public int QuoteId { get; set; }
    public string Quote { get; set; }
    public string Answer1 { get; set; }
    public string Answer2 { get; set; }
    public string Answer3 { get; set; }
}