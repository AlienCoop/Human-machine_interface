using Human_machine_interface.Backend;
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
    public partial class AddAndEditDisease : Form
    {
        public DataTable tbl1 = new DataTable();
        public AddAndEditDisease()
        {
            InitializeComponent();
        }

        private void AddAndEditDisease_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = comboBox1.Text.Substring(0, comboBox1.Text.IndexOf(' '));
            string temp1 = DiseaseTextbox.Text.ToLower();
            int temp3 = 0;
            switch (temp1)
            {
                case "простуда":
                    if (temp1 == "простуда")
                        temp3 = 1;
                    break;
                case "грипп":
                    if (temp1 == "грипп")
                        temp3 = 2;
                    break;
                case "коронавирус":
                    if (temp1 == "коронавирус")
                        temp3 = 3;
                    break;
            }
            Diseases cl = this.Owner as Diseases;
            cl.disease.IDworker = Convert.ToInt32(temp);
            cl.disease.IDdisease = Convert.ToInt32(temp3);
            cl.disease.DateOfStart = DateTextBox.Text;
            cl.disease.DateOfEnding = maskedTextBox1.Text;
            Close();
        }

        public void SetTBs(DataGridViewRow row)
        {

            comboBox1.Text = row.Cells[0].Value.ToString() + row.Cells[1].Value.ToString() + row.Cells[2].Value.ToString();
            DiseaseTextbox.Text = row.Cells[3].Value.ToString();
            DateTextBox.Text = row.Cells[4].Value.ToString();
            maskedTextBox1.Text = row.Cells[5].Value.ToString();
           
        }

        
    }
}