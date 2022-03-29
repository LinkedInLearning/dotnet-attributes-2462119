using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleConsole {
  public static class InfoLogger {

    public static void Log(string logMessage, string methodName = "") {
      var currentColor = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;

      Console.WriteLine($"{DateTime.Now}: {logMessage}");
      Console.ForegroundColor = currentColor;
    }

    public static void LogDetails(string logMessage,
                                  [CallerMemberName] string methodName = "",
                                  [CallerLineNumber] int lineNumber = 0
                                  ) {
      var currentColor = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Red;


      Console.WriteLine($"{DateTime.Now}");
      Console.WriteLine($" {methodName} - lineNumber: {lineNumber} ");
      Console.WriteLine($"    {logMessage}");
      Console.ForegroundColor = currentColor;
    }
  }
}
