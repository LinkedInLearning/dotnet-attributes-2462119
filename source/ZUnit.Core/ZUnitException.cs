namespace ZUnit.Core {

  /// <summary>
  /// Simple exception class that have actual and expected values
  /// </summary>
  public class ZUnitException : Exception {

    public ZUnitException(string actual, string expected, string userMessage) {
      Actual = actual;
      Expected = expected;
      UserMessage = userMessage;
    }

    public string Actual { get; set; }
    public string Expected { get; set; }
    public string UserMessage { get; set; }
  }
}