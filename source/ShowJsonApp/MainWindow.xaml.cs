using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleWpfApp {
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {
    public MainWindow() {
      InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e) {
      var card = new DataLib.CollectableCard
      {
        Id = 101,
        CardName = "Mingle",
        Slogan = "Double Trouble",
        CatalogPrice = 5.99M,
        BidPrice = 15.95M,
        Description = "Mingle excels at doing twice the work in half the time, with pinpoint accuracy.  These skills serve her well in her role as Senior Data Analyst for an international cloud computing company. She's also got a penchant for ballroom dance, line dancing, and pretty much any kind of activity that lets her groove to music.",
        PopularityIndex = 890,


        TeamName = TeamNames.BlueShadows,
      };
  
      var store = new DataLib.RetailStore
      { 
        StoreNumber = 243,
        BranchName = "Summer Valley Mall",
        SalesRegion = "Northwest",
        IsFranchised = true
      };

      var result = Smasher.Core.JsonSmasher.MakeJson(card);
      result += Smasher.Core.JsonSmasher.MakeJson(store);
      this.ResultsTextBox.Text = result;
    }
  }
}
