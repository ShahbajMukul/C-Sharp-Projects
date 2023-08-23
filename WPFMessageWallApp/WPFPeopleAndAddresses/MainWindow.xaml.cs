using ModelLibrary;
using PeopleModelLibrary;
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

namespace WPFPeopleAndAddresses
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		DataHandler peopleData = new DataHandler();
		PersonModel selectedPerson;
		public MainWindow()
		{
			InitializeComponent();

			RefreshLists();

		}

		private void RefreshLists()
		{
			peopleListBox.Items.Clear(); // Clear existing items

			foreach (PersonModel person in peopleData.People)
			{
				peopleListBox.Items.Add(person.ToString());
			}
		}

		private void addPersonButton_Click(object sender, RoutedEventArgs e)
		{
			if (string.IsNullOrEmpty(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text))
			{
				// error handling
			}
			else
			{
				PersonModel person = new PersonModel()
				{
					FirstName = firstNameTextBox.Text,
					LastName = lastNameTextBox.Text
				};

				peopleData.People.Add(person);
				RefreshLists();
			}
		}

		private void addAddressButton_Click(object sender, RoutedEventArgs e)
		{
			if (selectedPerson != null)
			{
				Addresses addressesPage = new Addresses(peopleData, selectedPerson);
				addressesPage.Show();
			}
		}

		private void peopleListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			selectedPerson = peopleData.People[peopleListBox.SelectedIndex];
		}
	}
}
