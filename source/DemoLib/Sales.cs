using System.Runtime.CompilerServices;
namespace DemoLib {

  
  public class Sales {

    [Obsolete]
    public bool GetCustomerApproval( decimal  salesAmount ) {
      if (salesAmount > 500)
      {
        return false;
      }
      else
      { 
        return true;
      }
    
    }
    [Obsolete]
    public void GetSalesTax()
    { 
    }
    [Obsolete]
    public void GetManagerApproval()
    { }
  }
}