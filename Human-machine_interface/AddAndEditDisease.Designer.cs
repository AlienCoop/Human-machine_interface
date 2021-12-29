namespace Human_machine_interface
{
    partial class AddAndEditDisease
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
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label marital_StatusLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.button1 = new System.Windows.Forms.Button();
            this.DiseaseTextbox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            birthdayLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            marital_StatusLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            birthdayLabel.Location = new System.Drawing.Point(23, 53);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(138, 18);
            birthdayLabel.TabIndex = 40;
            birthdayLabel.Text = "Дата заболевания";
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            educationLabel.Location = new System.Drawing.Point(23, 84);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(96, 18);
            educationLabel.TabIndex = 41;
            educationLabel.Text = "Тип болезни";
            // 
            // marital_StatusLabel
            // 
            marital_StatusLabel.AutoSize = true;
            marital_StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            marital_StatusLabel.Location = new System.Drawing.Point(23, 117);
            marital_StatusLabel.Name = "marital_StatusLabel";
            marital_StatusLabel.Size = new System.Drawing.Size(121, 18);
            marital_StatusLabel.TabIndex = 42;
            marital_StatusLabel.Text = "Дата окончания";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new System.Drawing.Point(142, 121);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 13);
            label1.TabIndex = 50;
            label1.Text = "(может быть пустой)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(23, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 18);
            label2.TabIndex = 52;
            label2.Text = "Сотрудник";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DiseaseTextbox
            // 
            this.DiseaseTextbox.Location = new System.Drawing.Point(259, 85);
            this.DiseaseTextbox.Name = "DiseaseTextbox";
            this.DiseaseTextbox.Size = new System.Drawing.Size(235, 20);
            this.DiseaseTextbox.TabIndex = 46;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(259, 51);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(235, 20);
            this.DateTextBox.TabIndex = 45;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(259, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 51;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(259, 121);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(235, 20);
            this.maskedTextBox1.TabIndex = 53;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // AddAndEditDisease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 272);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DiseaseTextbox);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(birthdayLabel);
            this.Controls.Add(educationLabel);
            this.Controls.Add(marital_StatusLabel);
            this.Name = "AddAndEditDisease";
            this.Text = "AddAndEditDisease";
            this.Load += new System.EventHandler(this.AddAndEditDisease_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DiseaseTextbox;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}