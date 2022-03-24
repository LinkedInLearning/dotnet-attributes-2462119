namespace Smasher.Core {

  [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
  public class SortAttribute : Attribute {
    public bool ReverseOrder { get; set; }
  }
}