using DBContactLibrary;
using DBContactLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsLab
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			DBContactLibrary.Models.Contact person;

			DeleteTextBoxInfo();
			if (listBox1.SelectedItem != null)
			{
				person = (DBContactLibrary.Models.Contact)listBox1.SelectedItem;
				firstNameTextBox.Text = person.FirstName;
				lastNameTextBox.Text = person.LastName;
				//emailTextBox.Text = person.Email;
				ssnTextBox.Text = person.SSN;


				//var personList = SQLRepository.GetAllContacts();

				//foreach (var item in SQLRepository.GetAllContacts())
				//{
				//	listBox1.Items.Add(item);
				//}

				//foreach (var item in person.PhoneNumber)
				//{
				//	listBoxPhonenumber.Items.Add(item);
				//}

			}
		}

		private void addPersonButton_Click(object sender, EventArgs e)
		{
			Contact p = new Contact();
			p.FirstName = firstNameTextBox.Text;
			p.LastName = lastNameTextBox.Text;
			//p.Email = emailTextBox.Text;
			p.SSN = ssnTextBox.Text;

			SQLRepository.AddNewContact(p.SSN, p.FirstName, p.LastName);



			listBox1.Items.Add(p);

			DeleteTextBoxInfo();
		}

		private void deletePersonButton_Click(object sender, EventArgs e)
		{
			Contact p;
			var index = listBox1.SelectedIndex;
			if (listBox1.SelectedItem != null)
			{
				p = (Contact)listBox1.Items[index];
				listBox1.Items.Remove(p);
				SQLRepository.DeleteContact(p.Id);
			}
			DeleteTextBoxInfo();
		}

		private void updatePersonButton_Click(object sender, EventArgs e)
		{
			Contact p;
			var index = listBox1.SelectedIndex;

			if (listBox1.SelectedItem != null)
			{
				p = (Contact)listBox1.Items[index];

				p.FirstName = firstNameTextBox.Text;
				p.LastName = lastNameTextBox.Text;
				//p.Email = emailTextBox.Text;
				p.SSN = ssnTextBox.Text;
				listBox1.Items[index] = p;
				SQLRepository.UpdateContactInformation(p.Id, p.SSN, p.FirstName, p.LastName);
			}

			DeleteTextBoxInfo();
		}

		public void DeleteTextBoxInfo()
		{
			firstNameTextBox.Text = null;
			lastNameTextBox.Text = null;
			emailTextBox.Text = null;
			ssnTextBox.Text = null;
			listBoxPhonenumber.Items.Clear();
		}



		private void listBoxPhonenumber_SelectedIndexChanged(object sender, EventArgs e)
		{
			Contact p;
			if (listBoxPhonenumber.Items != null)
			{
				//listBoxPhonenumber.Items.Clear();

				p = (Contact)listBoxPhonenumber.SelectedItem;
				//foreach (var item in p.PhoneNumber)
				//{
				//	listBoxPhonenumber.Items.Add(item);
				//}
			}
		}

		private void editPhoneNumber_Click(object sender, EventArgs e)
		{
			Contact p;


			var index = listBox1.SelectedIndex;
			if (listBox1.SelectedItem != null)
			{
				p = (Contact)listBox1.SelectedItem;
				SubForm subForm = new SubForm();
				//subForm.ShowForm(p.PhoneNumber);
				//if (subForm.ShowForm(p.PhoneNumber) == DialogResult.OK)
				//	MessageBox.Show("clesddalsfpkoad");
			}

			//SubForm subForm = new SubForm();
			//Person person = new Person();

			//subForm.ShowForm(person.PhoneNumber);
			//listBoxPhonenumber.Items.Clear();
			//foreach (var item in person.PhoneNumber)
			//{
			//	listBoxPhonenumber.Items.Add(item);
			//}
		}

		private void btnGetAllContacts_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			foreach (var item in SQLRepository.GetAllContacts())
			{
				//var lololo = item.FirstName + " " + item.LastName;
				////lastNameTextBox.Text = item.LastName;

				listBox1.Items.Add(item);
				//listBox1.Items.Add(lastNameTextBox.Text);

			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			DeleteTextBoxInfo();
			listBox1.Items.Clear();

			foreach (var item in SQLRepository.GetAllContacts())
				listBox1.Items.Add(item);

		}
	}
}
