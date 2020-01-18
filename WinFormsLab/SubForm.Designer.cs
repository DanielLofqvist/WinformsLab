namespace WinFormsLab
{
	partial class SubForm
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
			this.noLableSub = new System.Windows.Forms.Label();
			this.phoneNumberTextBoxSub = new System.Windows.Forms.TextBox();
			this.phoneListBox = new System.Windows.Forms.ListBox();
			this.okButtonSub = new System.Windows.Forms.Button();
			this.cancelButtonSub = new System.Windows.Forms.Button();
			this.addPhoneNumberButton = new System.Windows.Forms.Button();
			this.deleteButtonSub = new System.Windows.Forms.Button();
			this.updateButtonSub = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// noLableSub
			// 
			this.noLableSub.AutoSize = true;
			this.noLableSub.Location = new System.Drawing.Point(557, 36);
			this.noLableSub.Name = "noLableSub";
			this.noLableSub.Size = new System.Drawing.Size(101, 17);
			this.noLableSub.TabIndex = 4;
			this.noLableSub.Text = "Phonenumber:";
			// 
			// phoneNumberTextBoxSub
			// 
			this.phoneNumberTextBoxSub.Location = new System.Drawing.Point(560, 57);
			this.phoneNumberTextBoxSub.Name = "phoneNumberTextBoxSub";
			this.phoneNumberTextBoxSub.Size = new System.Drawing.Size(196, 22);
			this.phoneNumberTextBoxSub.TabIndex = 1;
			// 
			// phoneListBox
			// 
			this.phoneListBox.FormattingEnabled = true;
			this.phoneListBox.ItemHeight = 16;
			this.phoneListBox.Location = new System.Drawing.Point(30, 36);
			this.phoneListBox.Name = "phoneListBox";
			this.phoneListBox.Size = new System.Drawing.Size(304, 356);
			this.phoneListBox.TabIndex = 1;
			this.phoneListBox.TabStop = false;
			this.phoneListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// okButtonSub
			// 
			this.okButtonSub.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButtonSub.Location = new System.Drawing.Point(30, 399);
			this.okButtonSub.Name = "okButtonSub";
			this.okButtonSub.Size = new System.Drawing.Size(70, 25);
			this.okButtonSub.TabIndex = 3;
			this.okButtonSub.Text = "ok";
			this.okButtonSub.UseVisualStyleBackColor = true;
			// 
			// cancelButtonSub
			// 
			this.cancelButtonSub.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButtonSub.Location = new System.Drawing.Point(116, 400);
			this.cancelButtonSub.Name = "cancelButtonSub";
			this.cancelButtonSub.Size = new System.Drawing.Size(86, 24);
			this.cancelButtonSub.TabIndex = 4;
			this.cancelButtonSub.Text = "Cancel";
			this.cancelButtonSub.UseVisualStyleBackColor = true;
			// 
			// addPhoneNumberButton
			// 
			this.addPhoneNumberButton.Location = new System.Drawing.Point(560, 86);
			this.addPhoneNumberButton.Name = "addPhoneNumberButton";
			this.addPhoneNumberButton.Size = new System.Drawing.Size(75, 23);
			this.addPhoneNumberButton.TabIndex = 2;
			this.addPhoneNumberButton.Text = "Add";
			this.addPhoneNumberButton.UseVisualStyleBackColor = true;
			this.addPhoneNumberButton.Click += new System.EventHandler(this.addPhoneNumberButton_Click);
			// 
			// deleteButtonSub
			// 
			this.deleteButtonSub.Location = new System.Drawing.Point(560, 116);
			this.deleteButtonSub.Name = "deleteButtonSub";
			this.deleteButtonSub.Size = new System.Drawing.Size(75, 23);
			this.deleteButtonSub.TabIndex = 5;
			this.deleteButtonSub.Text = "Delete";
			this.deleteButtonSub.UseVisualStyleBackColor = true;
			// 
			// updateButtonSub
			// 
			this.updateButtonSub.Location = new System.Drawing.Point(560, 146);
			this.updateButtonSub.Name = "updateButtonSub";
			this.updateButtonSub.Size = new System.Drawing.Size(75, 23);
			this.updateButtonSub.TabIndex = 6;
			this.updateButtonSub.Text = "Update";
			this.updateButtonSub.UseVisualStyleBackColor = true;
			// 
			// SubForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updateButtonSub);
			this.Controls.Add(this.deleteButtonSub);
			this.Controls.Add(this.addPhoneNumberButton);
			this.Controls.Add(this.cancelButtonSub);
			this.Controls.Add(this.okButtonSub);
			this.Controls.Add(this.phoneListBox);
			this.Controls.Add(this.phoneNumberTextBoxSub);
			this.Controls.Add(this.noLableSub);
			this.Name = "SubForm";
			this.Text = "SubForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label noLableSub;
		private System.Windows.Forms.TextBox phoneNumberTextBoxSub;
		private System.Windows.Forms.ListBox phoneListBox;
		private System.Windows.Forms.Button okButtonSub;
		private System.Windows.Forms.Button cancelButtonSub;
		private System.Windows.Forms.Button addPhoneNumberButton;
		private System.Windows.Forms.Button deleteButtonSub;
		private System.Windows.Forms.Button updateButtonSub;
	}
}