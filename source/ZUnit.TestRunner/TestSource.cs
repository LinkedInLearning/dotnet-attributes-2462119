using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ZUnit.Core;

namespace ZUnit.TestRunner {

  public sealed class TestSource {

    

    public List<TestInfo> GetTestCases() {
      List<TestInfo> theMethods = new List<TestInfo>();
      var assemb = Assembly.GetExecutingAssembly();
      var refAssemblies = assemb.GetReferencedAssemblies();

      foreach (var theRef in refAssemblies)
      {
        var currentA = Assembly.Load(theRef);
        var currentTypes = currentA.GetTypes();

        var q = from ty in currentTypes
                from met in ty.GetMethods()
                from att in met.GetCustomAttributes(true)
                where att is FactAttribute || att is TraitAttribute

                select new TestInfo { Method = met, 
                                      MethodName = met.Name, 
                                      Fact = att as FactAttribute, 
                                      Trait = att as TraitAttribute,
                                      ClassName = met.DeclaringType.Name };

        theMethods.AddRange(q.ToList());


      }
      return theMethods;
    }

    public List<TestInfo> RunTests() {
      var factCases = GetTestCases().Where(x => x.Fact != null).ToList(); ;

      for (int counter = 0; counter < factCases.Count; counter++)
      {
        var currentTestInfo = factCases[counter];
        try
        {
          var instanceOfTestClass = Activator.CreateInstance(currentTestInfo.Method.DeclaringType);
          currentTestInfo.Method.Invoke(instanceOfTestClass, null);
          currentTestInfo.TestPassed = true;
        }
        catch (TargetInvocationException ex)
        {
          var myException = ex.InnerException as ZUnitException;
          currentTestInfo.TestPassed = false;
          currentTestInfo.TestFailedMessage = myException.UserMessage;
        }
        factCases[counter] = currentTestInfo;
      }

      return factCases;
    }
  }
}