namespace Human_machine_interface
{
    partial class Diseases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diseases));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Human_machine_interface.DataSet2();
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбраннуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerTableAdapter = new Human_machine_interface.DataSet2TableAdapters.WorkerTableAdapter();
            this.historyOfDiseaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historyOfDiseaseTableAdapter = new Human_machine_interface.DataSet2TableAdapters.HistoryOfDiseaseTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOfDiseaseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(712, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // dataSet2BindingSource
            // 
            this.dataSet2BindingSource.DataSource = this.dataSet2;
            this.dataSet2BindingSource.Position = 0;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolStripButton1});
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
            this.toolStripButton2.Size = new System.Drawing.Size(163, 22);
            this.toolStripButton2.Text = "Загрузить всех заболевших";
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
            this.редактироватьЗаписьToolStripMenuItem,
            this.удалитьВыбраннуюЗаписьToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(149, 22);
            this.toolStripSplitButton1.Text = "Работа с базой данных";
            // 
            // добавитьЗаписьToolStripMenuItem
            // 
            this.добавитьЗаписьToolStripMenuItem.Name = "добавитьЗаписьToolStripMenuItem";
            this.добавитьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.добавитьЗаписьToolStripMenuItem.Text = "Добавить запись";
            this.добавитьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаписьToolStripMenuItem_Click);
            // 
            // редактироватьЗаписьToolStripMenuItem
            // 
            this.редактироватьЗаписьToolStripMenuItem.Name = "редактироватьЗаписьToolStripMenuItem";
            this.редактироватьЗаписьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.редактироватьЗаписьToolStripMenuItem.Text = "Редактировать запись";
            this.редактироватьЗаписьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьЗаписьToolStripMenuItem_Click);
            // 
            // удалитьВыбраннуюЗаписьToolStripMenuItem
            // 
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Name = "удалитьВыбраннуюЗаписьToolStripMenuItem";
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Text = "Удалить выбранную запись";
            this.удалитьВыбраннуюЗаписьToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбраннуюЗаписьToolStripMenuItem_Click);
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // historyOfDiseaseBindingSource
            // 
            this.historyOfDiseaseBindingSource.DataMember = "HistoryOfDisease";
            this.historyOfDiseaseBindingSource.DataSource = this.dataSet2BindingSource;
            // 
            // historyOfDiseaseTableAdapter
            // 
            this.historyOfDiseaseTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(43, 22);
            this.toolStripButton1.Text = "Назад";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Diseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.workerBindingNavigator);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Diseases";
            this.Text = "Diseases";
            this.Load += new System.EventHandler(this.Diseases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historyOfDiseaseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet2BindingSource;
        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private DataSet2TableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource historyOfDiseaseBindingSource;
        private DataSet2TableAdapters.HistoryOfDiseaseTableAdapter historyOfDiseaseTableAdapter;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбраннуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}