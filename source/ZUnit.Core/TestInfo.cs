using System.Reflection;

namespace ZUnit.Core {

  public struct TestInfo {
    public bool TestPassed { get; set; }
    public string TestFailedMessage { get; set; }
    public string? MethodName { get; set; }
    public string? ClassName { get; set; }

    public MethodInfo Method { get; set; }
    public ZUnit.Core.FactAttribute? Fact { get; set; }
    public ZUnit.Core.TraitAttribute? Trait { get; set; }
  }
}