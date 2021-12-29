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
    public partial class AddAndEditVaccination : Form
    {
        public DataTable tbl1 = new DataTable();
        public DataTable tbl2 = new DataTable();
        public AddAndEditVaccination()
        {
            InitializeComponent();
        }

     

        private void AddAndEditVaccination_Load(object sender, EventArgs e)
        {

            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                SqlCommand cmd1 = new SqlCommand("SELECT concat(ID, ' ', Name,' ',Surname) as 'Name' from Worker", connection);

                SqlDataAdapter da = new SqlDataAdapter(cmd1);
                da.Fill(tbl1);
                this.comboBox1.DataSource = tbl1;
                this.comboBox1.DisplayMember = "Name";
                this.comboBox1.ValueMember = "Name";

                SqlCommand cmd2 = new SqlCommand("SELECT concat(ID,' ' ,NameOfVac) as 'Name1' from Vaccination", connection);

                SqlDataAdapter ad = new SqlDataAdapter(cmd2);
                ad.Fill(tbl2);
                this.comboBox2.DataSource = tbl2;
                this.comboBox2.DisplayMember = "Name1";
                this.comboBox2.ValueMember = "Name1";

            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vaccinations cl = this.Owner as Vaccinations;
            cl.vaccination.IDworker = Convert.ToInt32(comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(' ')));
            cl.vaccination.IDVaccination = Convert.ToInt32(comboBox2.Text.Substring(0, comboBox2.Text.IndexOf(' ')));
            cl.vaccination.DateOfVactination = DateTextBox.Text;
            Close();
        }
    }
}
