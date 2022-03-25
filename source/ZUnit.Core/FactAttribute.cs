namespace ZUnit.Core {

  [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
  public class FactAttribute : Attribute {

    // if Skip is null, then test is run
    // if Skip has a string value, then test is skipped, use the string in test runner to explain why.
    public virtual string? Skip { get; set; }

    public virtual int Timeout { get; set; }
  }
}