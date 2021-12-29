namespace Human_machine_interface
{
    partial class AddAndEditPatient
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label marital_StatusLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.StatusTextbox = new System.Windows.Forms.TextBox();
            this.EducationTextbox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.GenderTextbox = new System.Windows.Forms.TextBox();
            this.SurnameTextbox = new System.Windows.Forms.TextBox();
            this.NameTextbox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            marital_StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(6, 14);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 18);
            nameLabel.TabIndex = 24;
            nameLabel.Text = "Имя";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            surnameLabel.Location = new System.Drawing.Point(6, 45);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(73, 18);
            surnameLabel.TabIndex = 25;
            surnameLabel.Text = "Фамилия";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            genderLabel.Location = new System.Drawing.Point(6, 74);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(37, 18);
            genderLabel.TabIndex = 26;
            genderLabel.Text = "Пол";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthdayLabel.Location = new System.Drawing.Point(6, 104);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(116, 18);
            birthdayLabel.TabIndex = 27;
            birthdayLabel.Text = "Дата рождения";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            educationLabel.Location = new System.Drawing.Point(6, 140);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(102, 18);
            educationLabel.TabIndex = 28;
            educationLabel.Text = "Образование";
            // 
            // marital_StatusLabel
            // 
            marital_StatusLabel.AutoSize = true;
            marital_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            marital_StatusLabel.Location = new System.Drawing.Point(6, 172);
            marital_StatusLabel.Name = "marital_StatusLabel";
            marital_StatusLabel.Size = new System.Drawing.Size(161, 18);
            marital_StatusLabel.TabIndex = 29;
            marital_StatusLabel.Text = "Семейное положение";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusTextbox
            // 
            this.StatusTextbox.Location = new System.Drawing.Point(191, 173);
            this.StatusTextbox.Name = "StatusTextbox";
            this.StatusTextbox.Size = new System.Drawing.Size(235, 20);
            this.StatusTextbox.TabIndex = 34;
            // 
            // EducationTextbox
            // 
            this.EducationTextbox.Location = new System.Drawing.Point(191, 141);
            this.EducationTextbox.Name = "EducationTextbox";
            this.EducationTextbox.Size = new System.Drawing.Size(235, 20);
            this.EducationTextbox.TabIndex = 33;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(191, 106);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(235, 20);
            this.DateTextBox.TabIndex = 32;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // GenderTextbox
            // 
            this.GenderTextbox.Location = new System.Drawing.Point(191, 76);
            this.GenderTextbox.Name = "GenderTextbox";
            this.GenderTextbox.Size = new System.Drawing.Size(235, 20);
            this.GenderTextbox.TabIndex = 31;
            // 
            // SurnameTextbox
            // 
            this.SurnameTextbox.Location = new System.Drawing.Point(191, 45);
            this.SurnameTextbox.Name = "SurnameTextbox";
            this.SurnameTextbox.Size = new System.Drawing.Size(235, 20);
            this.SurnameTextbox.TabIndex = 36;
            // 
            // NameTextbox
            // 
            this.NameTextbox.Location = new System.Drawing.Point(191, 12);
            this.NameTextbox.Name = "NameTextbox";
            this.NameTextbox.Size = new System.Drawing.Size(235, 20);
            this.NameTextbox.TabIndex = 30;
            // 
            // AddAndEditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 284);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StatusTextbox);
            this.Controls.Add(this.EducationTextbox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.GenderTextbox);
            this.Controls.Add(this.SurnameTextbox);
            this.Controls.Add(this.NameTextbox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(genderLabel);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(educationLabel);
            this.Controls.Add(marital_StatusLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAndEditPatient";
            this.Text = "Редактировать данные пациента";
            this.Load += new System.EventHandler(this.EditPatient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox StatusTextbox;
        private System.Windows.Forms.TextBox EducationTextbox;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.TextBox GenderTextbox;
        private System.Windows.Forms.TextBox SurnameTextbox;
        private System.Windows.Forms.TextBox NameTextbox;
    }
}