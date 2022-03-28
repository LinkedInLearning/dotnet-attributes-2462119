using System;
using System.Windows.Controls;
using System.ComponentModel;
namespace WpfControlLib
{

  public partial class IpAddress : UserControl
  {
    public IpAddress()
    {
      InitializeComponent();
    }

 
    public String CurrentIP
    {
      get
      {
        String temp = String.Format("{0}.{1}.{2}.{3}", ipPart1TextBox.Text, ipPart2TextBox.Text, ipPart3TextBox.Text, ipPart4TextBox.Text);
        return temp;
      }
      set
      {
        String[] parts = value.Split('.');
        if (parts.Length != 4)
        {
          throw new ArgumentOutOfRangeException("CurrentIP must have four values");
        }

        ipPart1TextBox.Text = parts[0];
        ipPart2TextBox.Text = parts[1];
        ipPart3TextBox.Text = parts[2];
        ipPart4TextBox.Text = parts[3];
      }
    }

		
  }
}
