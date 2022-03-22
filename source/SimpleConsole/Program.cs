// See https://aka.ms/new-console-template for more information
public class SimpleConsole {
  static void Main(string[] args) {

    Console.WriteLine("Let's examine some .NET Attributes!");

    var sales = new DemoLib.Sales();

    bool approved = sales.GetCustomerApproval(350M);

    Console.WriteLine($"Sale is approved");

  }
}

