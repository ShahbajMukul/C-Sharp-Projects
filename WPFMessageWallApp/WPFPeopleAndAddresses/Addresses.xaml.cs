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
using System.Windows.Shapes;
using ModelLibrary;
using PeopleModelLibrary;

namespace WPFPeopleAndAddresses
{
    /// <summary>
    /// Interaction logic for Addresses.xaml
    /// </summary>
    public partial class Addresses : Window
    {
        private DataHandler peopleData;
        private PersonModel selectedPerson;
        public Addresses(DataHandler peopleData, PersonModel selectedPerson)
        {
            InitializeComponent();

            this.peopleData = peopleData;
            this.selectedPerson = selectedPerson;

            personNameLabel.Text = selectedPerson.ToString();
            RefreshLists();
        }

		private void RefreshLists()
		{
            addressesListBox.Items.Clear();

            foreach (var address in selectedPerson.addresses)
            {
                addressesListBox.Items.Add(GetFullAddress(address));
			}
           
		}

		private string GetFullAddress(AddressModel address)
		{
            return $"{address.StreetAddress}, {address.City} {address.State}, {address.ZipCode}";
		}

		private void addAddressButton_Click(object sender, RoutedEventArgs e)
		{
            if (string.IsNullOrEmpty(streetTextBox.Text) ||
					string.IsNullOrEmpty(cityTextBox.Text) ||
					string.IsNullOrEmpty(stateTextBox.Text) ||
					string.IsNullOrEmpty(zipCodeTextBox.Text))
            {

            }
            else
            {
                selectedPerson?.addresses.Add(new AddressModel()
                {
                    StreetAddress = streetTextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    ZipCode = zipCodeTextBox.Text
                });
                RefreshLists();

			}
		}


	}
}
