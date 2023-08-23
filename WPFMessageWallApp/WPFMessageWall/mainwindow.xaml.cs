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
using ModelLibrary;

namespace WPFMessageWall
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DataHandler peopleData = new DataHandler();
			
		}

		private void sayNameButton_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(firstNameTextBox.Text) && string.IsNullOrEmpty(firstNameTextBox.Text))
			{
				// if null or empty, do something
			}
			else
			{
				sayNameLabel.Text = firstNameTextBox.Text + " " + lastNameTextBox.Text;
			}
		}

		private void addPersonButton_Click(object sender, RoutedEventArgs e)
		{

		}
	}


}
