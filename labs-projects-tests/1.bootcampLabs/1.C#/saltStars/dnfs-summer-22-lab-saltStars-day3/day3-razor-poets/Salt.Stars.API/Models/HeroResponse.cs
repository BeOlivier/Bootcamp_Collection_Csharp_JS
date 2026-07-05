namespace Salt.Stars.API.Models
{
  public class HeroResponse
  {
    public Hero Hero { get; set; }

    // TODO: add RequestedAt date that should be set in the controller when you respond back
    public string RequestedAt {get; set;}
  }
}