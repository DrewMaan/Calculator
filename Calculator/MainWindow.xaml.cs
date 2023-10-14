using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void NumberButtonClick(object sender, RoutedEventArgs e) 
		{
			Button? numberButton = sender as Button;
			if(numberButton is null)
			{
				return;
			}

			Input.Text += numberButton.Content.ToString();
		}
	}
}
