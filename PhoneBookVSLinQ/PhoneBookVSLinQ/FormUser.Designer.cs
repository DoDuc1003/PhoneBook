namespace PhoneBookVSLinQ
{
    partial class FormUser
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.labelTypeNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.radioButtonLineLand = new System.Windows.Forms.RadioButton();
            this.radioButtonCellPhone = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(100, 50);
            this.labelName.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(100, 30);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(100, 100);
            this.labelEmail.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 30);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(100, 150);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(94, 16);
            this.labelPhoneNumber.TabIndex = 2;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // labelTypeNumber
            // 
            this.labelTypeNumber.AutoSize = true;
            this.labelTypeNumber.Location = new System.Drawing.Point(100, 200);
            this.labelTypeNumber.MinimumSize = new System.Drawing.Size(100, 30);
            this.labelTypeNumber.Name = "labelTypeNumber";
            this.labelTypeNumber.Size = new System.Drawing.Size(100, 30);
            this.labelTypeNumber.TabIndex = 3;
            this.labelTypeNumber.Text = "Type Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 250);
            this.label5.MinimumSize = new System.Drawing.Size(100, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date Of Birth";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(300, 50);
            this.textBoxName.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 30);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(300, 100);
            this.textBoxEmail.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(200, 30);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(300, 150);
            this.textBoxPhoneNumber.MinimumSize = new System.Drawing.Size(200, 30);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(200, 30);
            this.textBoxPhoneNumber.TabIndex = 7;
            // 
            // radioButtonLineLand
            // 
            this.radioButtonLineLand.AutoSize = true;
            this.radioButtonLineLand.Location = new System.Drawing.Point(300, 200);
            this.radioButtonLineLand.MinimumSize = new System.Drawing.Size(100, 30);
            this.radioButtonLineLand.Name = "radioButtonLineLand";
            this.radioButtonLineLand.Size = new System.Drawing.Size(100, 30);
            this.radioButtonLineLand.TabIndex = 8;
            this.radioButtonLineLand.TabStop = true;
            this.radioButtonLineLand.Text = "Line Land";
            this.radioButtonLineLand.UseVisualStyleBackColor = true;
            // 
            // radioButtonCellPhone
            // 
            this.radioButtonCellPhone.AutoSize = true;
            this.radioButtonCellPhone.Location = new System.Drawing.Point(500, 200);
            this.radioButtonCellPhone.MinimumSize = new System.Drawing.Size(100, 30);
            this.radioButtonCellPhone.Name = "radioButtonCellPhone";
            this.radioButtonCellPhone.Size = new System.Drawing.Size(100, 30);
            this.radioButtonCellPhone.TabIndex = 9;
            this.radioButtonCellPhone.TabStop = true;
            this.radioButtonCellPhone.Text = "Cell Phone";
            this.radioButtonCellPhone.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(300, 250);
            this.dateTimePicker1.MinimumSize = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(103, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(169, 66);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 549);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButtonCellPhone);
            this.Controls.Add(this.radioButtonLineLand);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTypeNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.Label labelTypeNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.RadioButton radioButtonLineLand;
        private System.Windows.Forms.RadioButton radioButtonCellPhone;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAdd;
    }
}