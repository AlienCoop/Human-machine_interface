namespace Human_machine_interface
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PatientButton = new System.Windows.Forms.ToolStripSplitButton();
            this.списокПациентовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.HelpButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.PatientButton,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator3,
            this.HelpButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(657, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PatientButton
            // 
            this.PatientButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PatientButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокПациентовToolStripMenuItem});
            this.PatientButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PatientButton.Name = "PatientButton";
            this.PatientButton.Size = new System.Drawing.Size(79, 22);
            this.PatientButton.Text = "Пациенты";
            // 
            // списокПациентовToolStripMenuItem
            // 
            this.списокПациентовToolStripMenuItem.Name = "списокПациентовToolStripMenuItem";
            this.списокПациентовToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.списокПациентовToolStripMenuItem.Text = "Список пациентов";
            this.списокПациентовToolStripMenuItem.Click += new System.EventHandler(this.списокПациентовToolStripMenuItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 22);
            this.toolStripButton1.Text = "Заболевания";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(66, 22);
            this.toolStripButton2.Text = "Прививки";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HelpButton.Image = ((System.Drawing.Image)(resources.GetObject("HelpButton.Image")));
            this.HelpButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(57, 22);
            this.HelpButton.Text = "Справка";
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(146, 22);
            this.toolStripButton3.Text = "Измерения сотрудников";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(101, 22);
            this.toolStripButton4.Text = "На предприятии";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 309);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.Text = "Паспорт здоровья сотрудника";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSplitButton PatientButton;
        private System.Windows.Forms.ToolStripMenuItem списокПациентовToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton HelpButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

