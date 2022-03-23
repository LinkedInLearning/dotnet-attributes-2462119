using System.Runtime.CompilerServices;
namespace DemoLib {
 
  public class Sales {

   
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
  }
}