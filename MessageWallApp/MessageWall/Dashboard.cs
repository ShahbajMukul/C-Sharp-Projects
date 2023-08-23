using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelLibrary;
using PeopleModelLibrary;

namespace MessageWall
{
	public partial class Dashboard : Form
	{
		DataHandler data = new DataHandler();
		

		public Dashboard()
		{
			InitializeComponent();
			BindingSource peopleBindingSource = new BindingSource();
			peopleBindingSource.DataSource = data.People;
			RefreshList();

		}

		private void RefreshList()
		{
			peopleListBox.Items.Clear();
			var namesList = new List<string>();

			foreach (var person in data.People)
			{
				namesList.Add(person.ToString());
			}

			peopleListBox.Items.AddRange(namesList.ToArray());
		}

		

		private void addNameButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(firstNameTextBox.Text) && string.IsNullOrEmpty(firstNameTextBox.Text))
			{
				// give an error
			}
			else
			{
				data.People.Add(new PersonModel() { FirstName = firstNameTextBox.Text, LastName = lastNameTextBox.Text });
				ClearBoxes();
				RefreshList();
			}
		}

		private void ClearBoxes()
		{
			firstNameTextBox.Clear();
			lastNameTextBox.Clear();
			firstNameTextBox.Focus();
		}
		

		private void addAddressButton_Click(object sender, EventArgs e) 
		{ 
			if (peopleListBox.SelectedIndex >= 0) 
			{	
				PersonModel selectedPerson = data.People[peopleListBox.SelectedIndex];
				AddressBar addressBar = new AddressBar(data, selectedPerson);
				addressBar.Show(); 
			} 
		}
	}
}
