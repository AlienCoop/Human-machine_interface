using Human_machine_interface.Backend;
using Human_machine_interface.Entities;
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
    public partial class Vaccinations : Form
    {
        public DataTable tbl1 = new DataTable();
        public Vaccination vaccination = new Vaccination();
        public Vaccinations()
        {
            InitializeComponent();
        }
        private void Vaccinations_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Functions.VaccinationSelectAll();

            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                SqlCommand cmd2 = new SqlCommand("SELECT concat(ID,' ' ,NameOfVac) as 'Name' from Vaccination", connection);

                SqlDataAdapter ad = new SqlDataAdapter(cmd2);
                ad.Fill(tbl1);
                this.comboBox1.DataSource = tbl1;
                this.comboBox1.DisplayMember = "Name";
                this.comboBox1.ValueMember = "Name";
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e) // загрузить всех сотрудников
        {
            dataGridView1.DataSource = Functions.VaccinationSelectAll();
        }

        private void toolStripButton4_Click(object sender, EventArgs e) // обновить
        {
            dataGridView1.DataSource = Functions.VaccinationSelectAll();
            
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // добавить
        {
            AddAndEditVaccination add = new AddAndEditVaccination();
            add.ShowDialog(this);
            Vaccination.InsertVaccination(vaccination, dataGridView1);
        }

        private void редактироватьВыбраннуюЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // редактировать
        {
            AddAndEditVaccination add = new AddAndEditVaccination();
            add.ShowDialog(this);
            Vaccination.UpdateVaccination(vaccination, dataGridView1);
        }

        private void удалитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e) // удалить
        {
            List<int> Ids = new List<int>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                Ids.Add(Convert.ToInt32(row.Cells[0].Value));
            if (MessageBox.Show("Вы уверены что хотите удалить выбранные записи?", "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Vaccination.DeleteVaccination(Ids);
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            
            int temp1 = Convert.ToInt32(comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(' ')));
            string dateStart = maskedTextBox1.Text;
            string dateEnd = maskedTextBox2.Text;
            dataGridView1.DataSource = Functions.CheckVaccination(temp1, dateStart, dateEnd);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 mm = Application.OpenForms[0] as Form1;
            mm.Show();
            Close();
        }
    }
}
