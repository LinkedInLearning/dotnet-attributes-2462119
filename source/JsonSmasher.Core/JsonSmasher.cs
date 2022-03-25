using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Smasher.Core {
  public static class JsonSmasher {

    public static string MakeJson<T>(T theClass) where T : class {
      
      Type type = typeof(T);

      // Get the class properties not include inherited properties
      var classProps = type.GetProperties(BindingFlags.Public 
                                          | BindingFlags.NonPublic 
                                          | BindingFlags.Static   
                                          | BindingFlags.Instance);
		

    // find the attribute...
    // reverse the sort order when requested

			StringBuilder sb = new StringBuilder();
      sb.Append('{');
      sb.AppendLine();
      foreach (var prop in classProps)
      {
        sb.AppendLine($"   \"{prop.Name}\" : \"{prop.GetValue(theClass)}\",");

      }

      sb.Append('}');
      sb.AppendLine();

      return sb.ToString();
    }
  }
}
