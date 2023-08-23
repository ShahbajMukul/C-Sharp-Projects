namespace MessageWall
{
	partial class AddressBar
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
			this.streetAddressLabel = new System.Windows.Forms.Label();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.peopleListBox = new System.Windows.Forms.ListBox();
			this.addAddressButton = new System.Windows.Forms.Button();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.cityLabel = new System.Windows.Forms.Label();
			this.stateTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.zipCodeTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.personNameLabel = new System.Windows.Forms.Label();
			this.addressListBox = new System.Windows.Forms.ListBox();
			this.returnToDashboardButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// streetAddressLabel
			// 
			this.streetAddressLabel.AutoSize = true;
			this.streetAddressLabel.Location = new System.Drawing.Point(52, 331);
			this.streetAddressLabel.Name = "streetAddressLabel";
			this.streetAddressLabel.Size = new System.Drawing.Size(77, 29);
			this.streetAddressLabel.TabIndex = 0;
			this.streetAddressLabel.Text = "Street";
			// 
			// streetTextBox
			// 
			this.streetTextBox.Location = new System.Drawing.Point(29, 380);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(126, 35);
			this.streetTextBox.TabIndex = 1;
			// 
			// peopleListBox
			// 
			this.peopleListBox.FormattingEnabled = true;
			this.peopleListBox.ItemHeight = 29;
			this.peopleListBox.Location = new System.Drawing.Point(12, 22);
			this.peopleListBox.Name = "peopleListBox";
			this.peopleListBox.Size = new System.Drawing.Size(328, 236);
			this.peopleListBox.TabIndex = 6;
			this.peopleListBox.SelectedIndexChanged += new System.EventHandler(this.peopleListBox_SelectedIndexChanged);
			// 
			// addAddressButton
			// 
			this.addAddressButton.Location = new System.Drawing.Point(706, 380);
			this.addAddressButton.Name = "addAddressButton";
			this.addAddressButton.Size = new System.Drawing.Size(163, 35);
			this.addAddressButton.TabIndex = 5;
			this.addAddressButton.Text = "Add Address";
			this.addAddressButton.UseVisualStyleBackColor = true;
			this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
			// 
			// cityTextBox
			// 
			this.cityTextBox.Location = new System.Drawing.Point(201, 380);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(126, 35);
			this.cityTextBox.TabIndex = 2;
			// 
			// cityLabel
			// 
			this.cityLabel.AutoSize = true;
			this.cityLabel.Location = new System.Drawing.Point(236, 331);
			this.cityLabel.Name = "cityLabel";
			this.cityLabel.Size = new System.Drawing.Size(53, 29);
			this.cityLabel.TabIndex = 7;
			this.cityLabel.Text = "City";
			// 
			// stateTextBox
			// 
			this.stateTextBox.Location = new System.Drawing.Point(386, 380);
			this.stateTextBox.Name = "stateTextBox";
			this.stateTextBox.Size = new System.Drawing.Size(126, 35);
			this.stateTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(415, 331);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 29);
			this.label1.TabIndex = 9;
			this.label1.Text = "State";
			// 
			// zipCodeTextBox
			// 
			this.zipCodeTextBox.Location = new System.Drawing.Point(533, 380);
			this.zipCodeTextBox.Name = "zipCodeTextBox";
			this.zipCodeTextBox.Size = new System.Drawing.Size(126, 35);
			this.zipCodeTextBox.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(542, 331);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 29);
			this.label2.TabIndex = 11;
			this.label2.Text = "Zip Code";
			// 
			// personNameLabel
			// 
			this.personNameLabel.AutoSize = true;
			this.personNameLabel.Location = new System.Drawing.Point(24, 285);
			this.personNameLabel.Name = "personNameLabel";
			this.personNameLabel.Size = new System.Drawing.Size(153, 29);
			this.personNameLabel.TabIndex = 13;
			this.personNameLabel.Text = "personName";
			// 
			// addressListBox
			// 
			this.addressListBox.FormattingEnabled = true;
			this.addressListBox.ItemHeight = 29;
			this.addressListBox.Location = new System.Drawing.Point(420, 22);
			this.addressListBox.Name = "addressListBox";
			this.addressListBox.Size = new System.Drawing.Size(533, 236);
			this.addressListBox.TabIndex = 7;
			// 
			// returnToDashboardButton
			// 
			this.returnToDashboardButton.Location = new System.Drawing.Point(201, 281);
			this.returnToDashboardButton.Name = "returnToDashboardButton";
			this.returnToDashboardButton.Size = new System.Drawing.Size(224, 36);
			this.returnToDashboardButton.TabIndex = 14;
			this.returnToDashboardButton.Text = "Add More People";
			this.returnToDashboardButton.UseVisualStyleBackColor = true;
			this.returnToDashboardButton.Click += new System.EventHandler(this.returnToDashboardButton_Click);
			// 
			// AddressBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 551);
			this.Controls.Add(this.returnToDashboardButton);
			this.Controls.Add(this.addressListBox);
			this.Controls.Add(this.personNameLabel);
			this.Controls.Add(this.zipCodeTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.stateTextBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cityTextBox);
			this.Controls.Add(this.cityLabel);
			this.Controls.Add(this.addAddressButton);
			this.Controls.Add(this.peopleListBox);
			this.Controls.Add(this.streetTextBox);
			this.Controls.Add(this.streetAddressLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "AddressBar";
			this.Text = "AddressBar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label streetAddressLabel;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.ListBox peopleListBox;
		private System.Windows.Forms.Button addAddressButton;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.Label cityLabel;
		private System.Windows.Forms.TextBox stateTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox zipCodeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label personNameLabel;
		private System.Windows.Forms.ListBox addressListBox;
		private System.Windows.Forms.Button returnToDashboardButton;
	}
}