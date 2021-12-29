using Human_machine_interface.Backend;
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
    public partial class AddAndEditMeterage : Form
    {
        public DataTable tbl1 = new DataTable();

        public AddAndEditMeterage()
        {
            InitializeComponent();
        }

        private void AddAndEditMeterage_Load(object sender, EventArgs e)
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


            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MeterageForm cl = this.Owner as MeterageForm;
            cl.meterage.IDworker = Convert.ToInt32(comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(' ')));
            cl.meterage.Growth = (float)Convert.ToDouble(GrowthTextbox.Text);
            cl.meterage.Weight = (float)Convert.ToDouble(WeightTextbox.Text);
            cl.meterage.DateMeterage = DateTextBox.Text;
            Close();
        }

        
    }
}
