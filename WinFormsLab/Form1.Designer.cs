namespace WinFormsLab
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.firstNameLable = new System.Windows.Forms.Label();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.emailLabel = new System.Windows.Forms.Label();
			this.ssnLabel = new System.Windows.Forms.Label();
			this.ssnTextBox = new System.Windows.Forms.TextBox();
			this.addPersonButton = new System.Windows.Forms.Button();
			this.deletePersonButton = new System.Windows.Forms.Button();
			this.updatePersonButton = new System.Windows.Forms.Button();
			this.listBoxPhonenumber = new System.Windows.Forms.ListBox();
			this.phoneNumberLable = new System.Windows.Forms.Label();
			this.editPhoneNumber = new System.Windows.Forms.Button();
			this.btnGetAllContacts = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(5, 14);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(267, 420);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// firstNameLable
			// 
			this.firstNameLable.AutoSize = true;
			this.firstNameLable.Location = new System.Drawing.Point(293, 13);
			this.firstNameLable.Name = "firstNameLable";
			this.firstNameLable.Size = new System.Drawing.Size(74, 17);
			this.firstNameLable.TabIndex = 1;
			this.firstNameLable.Text = "Firstname:";
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(299, 33);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(211, 22);
			this.firstNameTextBox.TabIndex = 2;
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(293, 58);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(74, 17);
			this.lastNameLabel.TabIndex = 3;
			this.lastNameLabel.Text = "Lastname:";
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(299, 78);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(211, 22);
			this.lastNameTextBox.TabIndex = 4;
			// 
			// emailTextBox
			// 
			this.emailTextBox.Location = new System.Drawing.Point(299, 132);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(211, 22);
			this.emailTextBox.TabIndex = 5;
			// 
			// emailLabel
			// 
			this.emailLabel.AutoSize = true;
			this.emailLabel.Location = new System.Drawing.Point(293, 112);
			this.emailLabel.Name = "emailLabel";
			this.emailLabel.Size = new System.Drawing.Size(46, 17);
			this.emailLabel.TabIndex = 6;
			this.emailLabel.Text = "Email:";
			// 
			// ssnLabel
			// 
			this.ssnLabel.AutoSize = true;
			this.ssnLabel.Location = new System.Drawing.Point(293, 161);
			this.ssnLabel.Name = "ssnLabel";
			this.ssnLabel.Size = new System.Drawing.Size(40, 17);
			this.ssnLabel.TabIndex = 7;
			this.ssnLabel.Text = "SSN:";
			// 
			// ssnTextBox
			// 
			this.ssnTextBox.Location = new System.Drawing.Point(299, 181);
			this.ssnTextBox.Name = "ssnTextBox";
			this.ssnTextBox.Size = new System.Drawing.Size(208, 22);
			this.ssnTextBox.TabIndex = 8;
			// 
			// addPersonButton
			// 
			this.addPersonButton.Location = new System.Drawing.Point(812, 48);
			this.addPersonButton.Name = "addPersonButton";
			this.addPersonButton.Size = new System.Drawing.Size(126, 27);
			this.addPersonButton.TabIndex = 9;
			this.addPersonButton.Text = "Add Person";
			this.addPersonButton.UseVisualStyleBackColor = true;
			this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
			// 
			// deletePersonButton
			// 
			this.deletePersonButton.Location = new System.Drawing.Point(812, 87);
			this.deletePersonButton.Name = "deletePersonButton";
			this.deletePersonButton.Size = new System.Drawing.Size(126, 27);
			this.deletePersonButton.TabIndex = 10;
			this.deletePersonButton.Text = "Delete Person";
			this.deletePersonButton.UseVisualStyleBackColor = true;
			this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
			// 
			// updatePersonButton
			// 
			this.updatePersonButton.Location = new System.Drawing.Point(812, 125);
			this.updatePersonButton.Name = "updatePersonButton";
			this.updatePersonButton.Size = new System.Drawing.Size(126, 27);
			this.updatePersonButton.TabIndex = 11;
			this.updatePersonButton.Text = "Update Person";
			this.updatePersonButton.UseVisualStyleBackColor = true;
			this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
			// 
			// listBoxPhonenumber
			// 
			this.listBoxPhonenumber.FormattingEnabled = true;
			this.listBoxPhonenumber.ItemHeight = 16;
			this.listBoxPhonenumber.Location = new System.Drawing.Point(299, 252);
			this.listBoxPhonenumber.Name = "listBoxPhonenumber";
			this.listBoxPhonenumber.Size = new System.Drawing.Size(208, 180);
			this.listBoxPhonenumber.TabIndex = 12;
			this.listBoxPhonenumber.SelectedIndexChanged += new System.EventHandler(this.listBoxPhonenumber_SelectedIndexChanged);
			// 
			// phoneNumberLable
			// 
			this.phoneNumberLable.AutoSize = true;
			this.phoneNumberLable.Location = new System.Drawing.Point(299, 229);
			this.phoneNumberLable.Name = "phoneNumberLable";
			this.phoneNumberLable.Size = new System.Drawing.Size(97, 17);
			this.phoneNumberLable.TabIndex = 13;
			this.phoneNumberLable.Text = "Phonenumber";
			// 
			// editPhoneNumber
			// 
			this.editPhoneNumber.Location = new System.Drawing.Point(299, 456);
			this.editPhoneNumber.Name = "editPhoneNumber";
			this.editPhoneNumber.Size = new System.Drawing.Size(136, 32);
			this.editPhoneNumber.TabIndex = 14;
			this.editPhoneNumber.Text = "Phonenumbers";
			this.editPhoneNumber.UseVisualStyleBackColor = true;
			this.editPhoneNumber.Click += new System.EventHandler(this.editPhoneNumber_Click);
			// 
			// btnGetAllContacts
			// 
			this.btnGetAllContacts.Location = new System.Drawing.Point(812, 461);
			this.btnGetAllContacts.Name = "btnGetAllContacts";
			this.btnGetAllContacts.Size = new System.Drawing.Size(126, 27);
			this.btnGetAllContacts.TabIndex = 15;
			this.btnGetAllContacts.Text = "Get all contacts";
			this.btnGetAllContacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnGetAllContacts.UseVisualStyleBackColor = true;
			this.btnGetAllContacts.Click += new System.EventHandler(this.btnGetAllContacts_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(987, 500);
			this.Controls.Add(this.btnGetAllContacts);
			this.Controls.Add(this.editPhoneNumber);
			this.Controls.Add(this.phoneNumberLable);
			this.Controls.Add(this.listBoxPhonenumber);
			this.Controls.Add(this.updatePersonButton);
			this.Controls.Add(this.deletePersonButton);
			this.Controls.Add(this.addPersonButton);
			this.Controls.Add(this.ssnTextBox);
			this.Controls.Add(this.ssnLabel);
			this.Controls.Add(this.emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.firstNameLable);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label firstNameLable;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.Label emailLabel;
		private System.Windows.Forms.Label ssnLabel;
		private System.Windows.Forms.TextBox ssnTextBox;
		private System.Windows.Forms.Button addPersonButton;
		private System.Windows.Forms.Button deletePersonButton;
		private System.Windows.Forms.Button updatePersonButton;
		private System.Windows.Forms.ListBox listBoxPhonenumber;
		private System.Windows.Forms.Label phoneNumberLable;
		private System.Windows.Forms.Button editPhoneNumber;
		private System.Windows.Forms.Button btnGetAllContacts;
	}
}

