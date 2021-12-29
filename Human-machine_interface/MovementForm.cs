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
    public partial class MovementForm : Form
    {
        public Movement movement = new Movement();
        public MovementForm()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // загрузить
        {
            dataGridView1.DataSource = Functions.MovementSelectAll();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) // обновить
        {
            dataGridView1.DataSource = Functions.MovementSelectAll();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // добавить
        {
            AddAndEditMovement add = new AddAndEditMovement();
            add.ShowDialog(this);
            Movement.InsertMovement(movement, dataGridView1);
        }

        private void редактироватьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e)  // редактировать
        {
            AddAndEditMovement add = new AddAndEditMovement();
            add.ShowDialog(this);
            Movement.UpdateMovement(movement, dataGridView1);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)  // удалить
        {
            List<int> Ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                Ids.Add(Convert.ToInt32(row.Cells[0].Value));
            if (MessageBox.Show("Вы уверены что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Movement.DeleteMovement(Ids);
        }

        private void toolStripButton3_Click(object sender, EventArgs e) // назад
        {
            Form1 mm = Application.OpenForms[0] as Form1;
            mm.Show();
            Close();
        }
    }
}
