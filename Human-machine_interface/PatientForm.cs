using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_machine_interface.Backend;
using Human_machine_interface.Entities;

namespace Human_machine_interface
{
    public partial class PatientForm : Form
    {
        public Patient patient = new Patient();
        public PatientForm()
        {
            InitializeComponent();
          
           //workerDataGridView.Columns[5].Visible = false;
           
            
        }

        //WorkerUpdate
        private void Patient_Load(object sender, EventArgs e)
        {
            workerDataGridView.DataSource = Functions.PatientsSelectAll();

        }
        
        private void toolStripButton4_Click(object sender, EventArgs e) // обновить
        {
            workerDataGridView.DataSource = Functions.PatientsSelectAll(); 
        }


        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAndEditPatient add = new AddAndEditPatient();
            add.ShowDialog(this);
            Patient.InsertWorker(patient, workerDataGridView);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> Ids = new List<int>();
            foreach (DataGridViewRow row in workerDataGridView.SelectedRows)
                Ids.Add(Convert.ToInt32(row.Cells[0].Value));
            if (MessageBox.Show("Вы уверены что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Patient.DeleteClient(Ids);
        }

        private void редактироватьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAndEditPatient edit = new AddAndEditPatient();
            patient.Id = Convert.ToInt32(workerDataGridView.SelectedRows[0].Cells[0].Value);
            edit.SetTBs(workerDataGridView.SelectedRows[0]);
            edit.ShowDialog(this);
            Patient.UpdateWorker(patient, workerDataGridView);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.tableAdapterManager.UpdateAll(this.dataSet2);
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void workerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Form1 mm = Application.OpenForms[0] as Form1;
            mm.Show();
            Close();
        }
    }
}
