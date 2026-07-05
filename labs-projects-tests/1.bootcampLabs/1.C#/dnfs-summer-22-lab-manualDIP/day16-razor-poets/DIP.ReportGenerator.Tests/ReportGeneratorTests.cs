using Xunit;

namespace DIP.ReportGenerator.Tests
{
  public class ReportGeneratorTests
  {
    [Fact]
    public void generates_excel_report()
    {
      // arrange
      // Hmmm ... I'd really like to pass in a moq here
      var generator = new Generator();

      // act
      // WHAT?! THIS RUNS FOREVER SLOW?
      generator.PrintReport(2);

      // assert
      // ??? There's nothing to assert...
    }
  }
}
