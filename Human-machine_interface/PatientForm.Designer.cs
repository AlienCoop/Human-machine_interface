namespace Human_machine_interface
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.workerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet2 = new Human_machine_interface.DataSet2();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.добавитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбраннуюЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workerDataGridView = new System.Windows.Forms.DataGridView();
            this.workerTableAdapter = new Human_machine_interface.DataSet2TableAdapters.WorkerTableAdapter();
            this.tableAdapterManager = new Human_machine_interface.DataSet2TableAdapters.TableAdapterManager();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).BeginInit();
            this.workerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // workerBindingNavigator
            // 
            this.workerBindingNavigator.AddNewItem = null;
            this.workerBindingNavigator.BindingSource = this.workerBindingSource;
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
            this.workerBindingNavigator.Size = new System.Drawing.Size(856, 25);
            this.workerBindingNavigator.TabIndex = 0;
            this.workerBindingNavigator.Text = "bindingNavigator1";
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.dataSet2;
            // 
            // dataSet2
            // 
            this.dataSet2.DataSetName = "DataSet2";
            this.dataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(126, 22);
            this.toolStripButton2.Text = "Загрузить пациентов";
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
            this.toolStripSplitButton1.ButtonClick += new System.EventHandler(this.toolStripSplitButton1_ButtonClick);
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
            // workerDataGridView
            // 
            this.workerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.workerDataGridView.Location = new System.Drawing.Point(12, 28);
            this.workerDataGridView.Name = "workerDataGridView";
            this.workerDataGridView.Size = new System.Drawing.Size(743, 314);
            this.workerDataGridView.TabIndex = 1;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryOfPositionTableAdapter = null;
            this.tableAdapterManager.Education1TableAdapter = null;
            this.tableAdapterManager.EducationDocumentTableAdapter = null;
            this.tableAdapterManager.GenderTableAdapter = null;
            this.tableAdapterManager.HistoryMeterageTableAdapter = null;
            this.tableAdapterManager.HistoryOfDiseaseTableAdapter = null;
            this.tableAdapterManager.MaritalStatusTableAdapter = null;
            this.tableAdapterManager.MovementOnJobHistoryTableAdapter = null;
            this.tableAdapterManager.NameOfDiseaseTableAdapter = null;
            this.tableAdapterManager.PositionOfWorkerTableAdapter = null;
            this.tableAdapterManager.StatusTableAdapter = null;
            this.tableAdapterManager.SubdivisionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Human_machine_interface.DataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VaccinationOfWorkerTableAdapter = null;
            this.tableAdapterManager.VaccinationTableAdapter = null;
            this.tableAdapterManager.WorkerTableAdapter = this.workerTableAdapter;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 23);
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
            // PatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 445);
            this.Controls.Add(this.workerDataGridView);
            this.Controls.Add(this.workerBindingNavigator);
            this.Name = "PatientForm";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingNavigator)).EndInit();
            this.workerBindingNavigator.ResumeLayout(false);
            this.workerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet2 dataSet2;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private DataSet2TableAdapters.WorkerTableAdapter workerTableAdapter;
        private DataSet2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator workerBindingNavigator;
        private System.Windows.Forms.DataGridView workerDataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбраннуюЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}