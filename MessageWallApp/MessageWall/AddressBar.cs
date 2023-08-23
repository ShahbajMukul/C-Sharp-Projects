using ModelLibrary;
using PeopleModelLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageWall
{
	public partial class AddressBar : Form
	{
		private DataHandler data;
		private PersonModel selectedPerson;
		
		public AddressBar(DataHandler data, PersonModel selectedPerson)
		{
			InitializeComponent();
			this.data = data;
			this.selectedPerson = selectedPerson;
			personNameLabel.Text = GetFullName(selectedPerson);
			RefreshList();
		}

		private void RefreshList()
		{
			peopleListBox.Items.Clear();
			var namesList = new List<string>();

			foreach (var person in data.People)
			{
				namesList.Add(GetFullName(person));
			}

			peopleListBox.Items.AddRange(namesList.ToArray());

			addressListBox.Items.Clear();

			var addressesList = new List<string>();

			if (selectedPerson.addresses != null)
			{
				foreach (var address in selectedPerson.addresses)
				{
					addressesList.Add(GetFullAddress(address));
				}

				addressListBox.Items.AddRange(addressesList.ToArray());
			}
		}

		private string GetFullAddress(AddressModel address)
		{
			return $"{address.StreetAddress}, {address.City}, {address.State}, {address.ZipCode}";
		}

		private string GetFullName(PersonModel person)
		{
			return $"{person.FirstName} {person.LastName}";
		}

		private void peopleListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			selectedPerson = data.People[peopleListBox.SelectedIndex];
			personNameLabel.Text = GetFullName(selectedPerson);
		}

		private void addAddressButton_Click(object sender, EventArgs e)
		{
			if (selectedPerson != null)
			{
				if (string.IsNullOrEmpty(streetTextBox.Text) ||
					string.IsNullOrEmpty(cityTextBox.Text) ||
					string.IsNullOrEmpty(stateTextBox.Text) ||
					string.IsNullOrEmpty(zipCodeTextBox.Text))
				{
					// do null or empty warning
				}
				else
				{
					int zipCode = 00000;
					bool isValidZip = int.TryParse(zipCodeTextBox.Text, out zipCode);

					selectedPerson?.addresses.Add(new AddressModel
					{
						StreetAddress = streetTextBox.Text,
						City = cityTextBox.Text,
						State = stateTextBox.Text,
						ZipCode = zipCode
						 
					});

					RefreshList();
				}
			}
		}

		private void returnToDashboardButton_Click(object sender, EventArgs e)
		{
			this.Close();
			
		}
	}
}
