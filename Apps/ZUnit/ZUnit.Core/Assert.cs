namespace ZUnit.Core {

  public static class Assert {

    public static void DateEqual(DateOnly first, DateOnly second, string message) {
      if (first.Equals(second))
      {
        return;
      }
      else
      {
        throw new ZUnit.Core.ZUnitException(first.ToString(), second.ToString(), message);
      }
    }

    public static void DecimalEqual(decimal first, decimal second, string message) {
      if (first.Equals(second))
      {
        return;
      }
      else
      {
        throw new ZUnit.Core.ZUnitException(first.ToString(), second.ToString(), message);
      }
    }

    public static void Equal(object first, object second, string message) {
      if (first.Equals(second))
      {
        return;
      }
      else
      {
        throw new ZUnit.Core.ZUnitException(first.ToString(), second.ToString(), message);
      }
    }
  }
}