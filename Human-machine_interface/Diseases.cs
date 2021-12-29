using Human_machine_interface.Backend;
using Human_machine_interface.Entities;
using Human_machine_interface.Entities.Human_machine_interface.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_machine_interface
{
    public partial class Diseases : Form
    {
        public Disease disease = new Disease();

        public Diseases()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // обновить
        {
            dataGridView1.DataSource = Functions.DiseaseSelectAll();
        }

        private void Diseases_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.DiseaseSelectAll();

        }

        private void удалитьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // удалить
        {
            List<int> Ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                Ids.Add(Convert.ToInt32(row.Cells[0].Value));
            if (MessageBox.Show("Вы уверены что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Disease.DeleteDisease(Ids);
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // добавить
        {
            AddAndEditDisease add = new AddAndEditDisease();
            add.ShowDialog(this);
            Disease.InsertDisease(disease, dataGridView1);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.DiseaseSelectAll();
        }

        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAndEditDisease edit = new AddAndEditDisease();
            disease.IDworker = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            edit.SetTBs(dataGridView1.SelectedRows[0]);
            edit.ShowDialog(this);
            Disease.UpdateDisease(disease, dataGridView1);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 mm = Application.OpenForms[0] as Form1;
            mm.Show();
            Close();
        }
    }
}