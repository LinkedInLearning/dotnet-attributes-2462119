using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace ShowAttributeTypes {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
      GetData("Ob");
    }

    private List<AttributeData> _attributeData;

  

    public void GetData(string searchString) {
    
      searchString = searchString.ToUpper();
      var types = System.AppDomain.CurrentDomain.GetAssemblies()
                  .SelectMany
                  (
                    a => a.GetTypes()
                  );
      
      var q = from t in types
              let truncated = t.Name.Replace("Attribute", "")
              where t.IsSubclassOf(typeof(System.Attribute))
              && t.Name.StartsWith(searchString,true,null)
              orderby t.Name
              let att = t.GetCustomAttributes(false).FirstOrDefault(x => x is AttributeUsageAttribute) as AttributeUsageAttribute
              select new AttributeData {ShortName = truncated, 
                                        FullName = t.Name, 
                                        AssemblyName=t.Assembly.GetName().Name, 
                                        AttributeType= t,
                                        Targets = att?.ValidOn.ToString() ?? "All"};
      _attributeData = q.ToList();

 
      this.DataContext = _attributeData;
      CountTextBlock.Text = $"Count: {_attributeData.Count()}";
    }

    private void TextBox_TextChanged(object sender, TextChangedEventArgs e) {
      GetData(SearchTextBox.Text);
    }
  }
  public class AttributeData {
    public string ShortName { get; set; }
    public string FullName { get; set; }
    public string AssemblyName { get; set; }
    public System.Type AttributeType { get; set; }
    public string Targets { get; set; }


  }
}
