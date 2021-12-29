namespace Human_machine_interface
{
    partial class AddAndEditVaccination
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(33, 31);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(83, 18);
            nameLabel.TabIndex = 37;
            nameLabel.Text = "Сотрудник";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(33, 108);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 18);
            label1.TabIndex = 46;
            label1.Text = "Дата прививки";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(218, 109);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(235, 20);
            this.DateTextBox.TabIndex = 45;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(33, 70);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 18);
            label2.TabIndex = 47;
            label2.Text = "Название прививки";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 21);
            this.comboBox2.TabIndex = 53;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 54;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddAndEditVaccination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 229);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(nameLabel);
            this.Name = "AddAndEditVaccination";
            this.Text = "AddAndEditVaccination";
            this.Load += new System.EventHandler(this.AddAndEditVaccination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
    }
}