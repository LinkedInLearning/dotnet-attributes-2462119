using System.Linq;
using System.Windows;

namespace ZUnit.TestRunner {

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window {

    public MainWindow() {
      InitializeComponent();
      // hack to get test lib loaded.
      var temp = new BigStar.Brokerage.Tests.TestThePaymentDate();
    }

    private void RunButton_Click(object sender, RoutedEventArgs e) {
      var testCases = new TestSource().GetTestCases();

      FactsListBox.DataContext = testCases.Where(x => x.Fact != null);
    }

    private void TraitsButton_Click(object sender, RoutedEventArgs e) {
      var testCases = new TestSource().GetTestCases();
      TraitsListBox.DataContext = testCases.Where(x => x.Trait != null); ;
    }

    private void RunButton_Click_1(object sender, RoutedEventArgs e) {
      var source = new TestSource();
      ResultsListBox.DataContext = source.RunTests();
    }
  }
}