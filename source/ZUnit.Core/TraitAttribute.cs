namespace ZUnit.Core {

  [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = true)]
  public class TraitAttribute : Attribute {

    public TraitAttribute(string name, string value) {
      Name = name;
      Value = value;
    }

    public string Name { get; set; }
    public string Value { get; set; }
  }
}