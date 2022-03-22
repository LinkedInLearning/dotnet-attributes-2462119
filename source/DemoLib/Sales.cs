namespace DemoLib {
  [Obsolete]
  public class Sales {

    [Obsolete ("Use the IsValidSale method instead")]
    public bool GetCustomerApproval(decimal salesAmount) {
      if (salesAmount > 500)
      {
        return false;
      }
      else
      { 
        return true;
      }
    
    }
  }
}