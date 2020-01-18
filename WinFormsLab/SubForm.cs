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
	public partial class SubForm : Form
	{
		public List<string> pn;

		public SubForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowForm(List<string> pn)
		{
			this.pn = pn;

			foreach (var item in pn)
			{
				phoneListBox.Items.Add(item);
			}


			return ShowDialog(); 
		}

	
		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (phoneListBox.SelectedItem != null)
			{
				phoneNumberTextBoxSub.Text = (string)phoneListBox.SelectedItem;

			}



		}

		private void addPhoneNumberButton_Click(object sender, EventArgs e)
		{
			phoneListBox.Items.Add(phoneNumberTextBoxSub.Text);
			pn.Add(phoneNumberTextBoxSub.Text);

			//Person person = new Person();
			//foreach (var item in pn)
			//{
			//	person.PhoneNumber.Add(item);
			//}

		}
	}
}
