using SimpleConsole;

public class StartHere {
  static void Main(string[] args) {

    PrepareDocument();
    ZipDocument();

  }

  public static void PrepareDocument() {
    Console.WriteLine("Opening document");

    InfoLogger.Log("Done opening document.");
  }

  public static void ZipDocument() {
    Console.WriteLine("Compressing document");

    InfoLogger.Log("Done compressing document.");
  }

}


