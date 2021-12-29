namespace Human_machine_interface
{
    partial class MovementForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementForm));
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = null;
            this.workerBindingNavigator.CountItem = null;
            this.workerBindingNavigator.DeleteItem = null;
            this.workerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton4,
            this.toolStripSplitButton1,
            this.toolStripButton3});
            this.workerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.workerBindingNavigator.MoveFirstItem = null;
            this.workerBindingNavigator.MoveLastItem = null;
            this.workerBindingNavigator.MoveNextItem = null;
            this.workerBindingNavigator.MovePreviousItem = null;
            this.workerBindingNavigator.Name = "workerBindingNavigator";
            this.workerBindingNavigator.PositionItem = null;
            this.workerBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.workerBindingNavigator.TabIndex = 1;
            this.workerBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(113, 22);
            this.toolStripButton2.Text = "Загрузить таблицу";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(65, 22);
            this.toolStripButton4.Text = "Обновить";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаписьToolStripMenuItem,
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem,
            this.удалитьЗаписьToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(149, 22);
            this.toolStripSplitButton1.Text = "Работа с базой данных";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // редактироватьВыбраннуюЗаписьToolStripMenuItem
            // 
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem.Name = "редактироватьВыбраннуюЗаписьToolStripMenuItem";
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem.Text = "Редактировать выбранную запись";
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьВыбраннуюЗаписьToolStripMenuItem_Click);
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            this.удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            this.удалитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            this.удалитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьЗаписьToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(43, 22);
            this.toolStripButton3.Text = "Назад";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 365);
            this.dataGridView1.TabIndex = 2;
            // 
            // MovementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.workerBindingNavigator);
            this.Name = "MovementForm";
            this.Text = "Сотрудники в организации";
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбраннуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}