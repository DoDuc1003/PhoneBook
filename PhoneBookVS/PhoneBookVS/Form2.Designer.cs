namespace PhoneBookVS
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.typePhone = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.dateofBirth = new System.Windows.Forms.Label();
            this.textBoxOfName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxTypePhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lineLand = new System.Windows.Forms.RadioButton();
            this.cellPhone = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(83, 57);
            this.LabelName.MinimumSize = new System.Drawing.Size(100, 30);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(100, 30);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "Name";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Location = new System.Drawing.Point(83, 111);
            this.PhoneNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(100, 30);
            this.PhoneNumber.TabIndex = 2;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // typePhone
            // 
            this.typePhone.AutoSize = true;
            this.typePhone.Location = new System.Drawing.Point(83, 156);
            this.typePhone.MinimumSize = new System.Drawing.Size(100, 30);
            this.typePhone.Name = "typePhone";
            this.typePhone.Size = new System.Drawing.Size(100, 30);
            this.typePhone.TabIndex = 3;
            this.typePhone.Text = "Type Phone";
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.Location = new System.Drawing.Point(86, 212);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(32, 13);
            this.EmailAddress.TabIndex = 4;
            this.EmailAddress.Text = "Email";
            // 
            // dateofBirth
            // 
            this.dateofBirth.AutoSize = true;
            this.dateofBirth.Location = new System.Drawing.Point(86, 266);
            this.dateofBirth.Name = "dateofBirth";
            this.dateofBirth.Size = new System.Drawing.Size(65, 13);
            this.dateofBirth.TabIndex = 5;
            this.dateofBirth.Text = "Date of birth";
            // 
            // textBoxOfName
            // 
            this.textBoxOfName.Location = new System.Drawing.Point(272, 57);
            this.textBoxOfName.Name = "textBoxOfName";
            this.textBoxOfName.Size = new System.Drawing.Size(300, 20);
            this.textBoxOfName.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(272, 111);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(300, 20);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // textBoxTypePhone
            // 
            this.textBoxTypePhone.Location = new System.Drawing.Point(272, 156);
            this.textBoxTypePhone.Name = "textBoxTypePhone";
            this.textBoxTypePhone.Size = new System.Drawing.Size(300, 20);
            this.textBoxTypePhone.TabIndex = 8;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(272, 204);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(300, 20);
            this.textBoxEmail.TabIndex = 9;
            // 
            // dateTimePickerDateOfBirth
            // 
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(272, 258);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(224, 20);
            this.dateTimePickerDateOfBirth.TabIndex = 10;
            // 
            // lineLand
            // 
            this.lineLand.AutoSize = true;
            this.lineLand.Location = new System.Drawing.Point(631, 158);
            this.lineLand.Name = "lineLand";
            this.lineLand.Size = new System.Drawing.Size(69, 17);
            this.lineLand.TabIndex = 11;
            this.lineLand.TabStop = true;
            this.lineLand.Text = "LineLand";
            this.lineLand.UseVisualStyleBackColor = true;
            // 
            // cellPhone
            // 
            this.cellPhone.AutoSize = true;
            this.cellPhone.Location = new System.Drawing.Point(736, 158);
            this.cellPhone.Name = "cellPhone";
            this.cellPhone.Size = new System.Drawing.Size(76, 17);
            this.cellPhone.TabIndex = 12;
            this.cellPhone.TabStop = true;
            this.cellPhone.Text = "Cell Phone";
            this.cellPhone.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 499);
            this.Controls.Add(this.cellPhone);
            this.Controls.Add(this.lineLand);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTypePhone);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxOfName);
            this.Controls.Add(this.dateofBirth);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.typePhone);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label typePhone;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.Label dateofBirth;
        private System.Windows.Forms.TextBox textBoxOfName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxTypePhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.RadioButton lineLand;
        private System.Windows.Forms.RadioButton cellPhone;
    }
}