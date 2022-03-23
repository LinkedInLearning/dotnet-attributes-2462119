using ZUnit.Core;

namespace BigStar.Brokerage.Tests {

  public class TestThePaymentDate {

    [Fact]
    [Trait("Category", "Financial")]
    [Trait("TesterName", "Walt")]
    [Trait("Version", "V1.443")]
    public void DateIs30DaysInFuture() {
      var pd = new BigStar.Brokerage.PaymentSystem.PaymentDate();
      DateOnly sampleDate = DateOnly.Parse("7/6/2011"); // will result in a weekday

      var resultWhichShouldBe30DaysLater = pd.CalculateFuturePaymentDate(sampleDate);

      ZUnit.Core.Assert.DateEqual(resultWhichShouldBe30DaysLater, sampleDate.AddDays(30), "Expected date is not 30 days in the future.");
    }

    [Fact(Skip = "Database connection not setup", Timeout = 30)]
    [Trait("Category", "Financial")]
    public void ReturnsMondayIfProposedDateIsSunday() {
      var pd = new BigStar.Brokerage.PaymentSystem.PaymentDate();

      DateOnly sampleDate = DateOnly.Parse("7/8/2011");

      var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);

      Assert.Equal(resultDateWhichShouldBeMonday.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");
    }

    [Fact]
    [Trait("Category", "Financial")]
    public void ReturnsMondayIfProposedDateIsSaturday() {
      var pd = new BigStar.Brokerage.PaymentSystem.PaymentDate();

      DateOnly sampleDate = DateOnly.Parse("7/7/2011");

      var resultDateWhichShouldBeMonday = pd.CalculateFuturePaymentDate(sampleDate);
      Assert.Equal(resultDateWhichShouldBeMonday.DayOfWeek, DayOfWeek.Monday, "Expected date is not Monday.");
    }
  }
}