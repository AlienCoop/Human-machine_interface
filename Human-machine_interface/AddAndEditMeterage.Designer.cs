namespace Human_machine_interface
{
    partial class AddAndEditMeterage
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label educationLabel;
            System.Windows.Forms.Label label2;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.WeightTextbox = new System.Windows.Forms.TextBox();
            this.GrowthTextbox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            educationLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 21);
            this.comboBox1.TabIndex = 56;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(12, 125);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(122, 18);
            label1.TabIndex = 55;
            label1.Text = "Дата измерений";
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(137, 123);
            this.DateTextBox.Mask = "00/00/0000";
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(235, 20);
            this.DateTextBox.TabIndex = 54;
            this.DateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(12, 9);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(83, 18);
            nameLabel.TabIndex = 53;
            nameLabel.Text = "Сотрудник";
            // 
            // WeightTextbox
            // 
            this.WeightTextbox.Location = new System.Drawing.Point(137, 83);
            this.WeightTextbox.Name = "WeightTextbox";
            this.WeightTextbox.Size = new System.Drawing.Size(235, 20);
            this.WeightTextbox.TabIndex = 58;
            // 
            // educationLabel
            // 
            educationLabel.AutoSize = true;
            educationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            educationLabel.Location = new System.Drawing.Point(12, 44);
            educationLabel.Name = "educationLabel";
            educationLabel.Size = new System.Drawing.Size(42, 18);
            educationLabel.TabIndex = 57;
            educationLabel.Text = "Рост";
            // 
            // GrowthTextbox
            // 
            this.GrowthTextbox.Location = new System.Drawing.Point(137, 45);
            this.GrowthTextbox.Name = "GrowthTextbox";
            this.GrowthTextbox.Size = new System.Drawing.Size(235, 20);
            this.GrowthTextbox.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(12, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 18);
            label2.TabIndex = 59;
            label2.Text = "Вес";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 62;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddAndEditMeterage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 244);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.GrowthTextbox);
            this.Controls.Add(label2);
            this.Controls.Add(this.WeightTextbox);
            this.Controls.Add(educationLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(nameLabel);
            this.Name = "AddAndEditMeterage";
            this.Text = "AddAndEditMeterage";
            this.Load += new System.EventHandler(this.AddAndEditMeterage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.MaskedTextBox DateTextBox;
        private System.Windows.Forms.TextBox WeightTextbox;
        private System.Windows.Forms.TextBox GrowthTextbox;
        private System.Windows.Forms.Button button2;
    }
}