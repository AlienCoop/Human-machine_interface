using Human_machine_interface.Backend;
using Human_machine_interface.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_machine_interface
{
    public partial class MeterageForm : Form
    {
        public Meterage meterage = new Meterage();
        public MeterageForm()
        {
            InitializeComponent();
        }
        private void MeterageForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.MeterageSelectAll();
        }
        private void toolStripButton2_Click(object sender, EventArgs e) // загрузить все измерения
        {
            dataGridView1.DataSource = Functions.MeterageSelectAll();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) // обновить
        {
            dataGridView1.DataSource = Functions.MeterageSelectAll();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // добавить запись
        {
            AddAndEditMeterage add = new AddAndEditMeterage();
            add.ShowDialog(this);
            Meterage.InsertMeterage(meterage, dataGridView1);
        }

        private void редактироватьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // редактировать запись
        {
            AddAndEditMeterage edit = new AddAndEditMeterage();
            edit.ShowDialog(this);
            Meterage.UpdateMeterage(meterage, dataGridView1);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // удалить запись
        {
            List<int> Ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                Ids.Add(Convert.ToInt32(row.Cells[0].Value));
            if (MessageBox.Show("Вы уверены что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Meterage.DeleteMeterage(Ids);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 mm = Application.OpenForms[0] as Form1;
            mm.Show();
            Close();
        }
    }
}
