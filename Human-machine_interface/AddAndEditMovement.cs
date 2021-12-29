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
    public partial class AddAndEditMovement : Form
    {
        public DataTable workerTB = new DataTable();
        public DataTable subdivisionTB = new DataTable();
        public DataTable positionTB = new DataTable();
        public DataTable categoryTB = new DataTable();

        public AddAndEditMovement()
        {
            InitializeComponent();
        }

        private void AddAndEditMovement_Load(object sender, EventArgs e)
        {

            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                SqlCommand cmd1 = new SqlCommand("SELECT concat(ID, ' ', Name,' ',Surname) as 'Name' from Worker", connection);

                SqlDataAdapter adapterWorker = new SqlDataAdapter(cmd1);
                adapterWorker.Fill(workerTB);
                this.WorkerTextbox.DataSource = workerTB;
                this.WorkerTextbox.DisplayMember = "Name";
                this.WorkerTextbox.ValueMember = "Name";

                SqlCommand cmd2 = new SqlCommand("SELECT concat(SubdivisionID, ' ', SubdivisionName) as 'SubdivisionName' from Subdivision", connection);

                SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
                adapter2.Fill(subdivisionTB);
                this.SubdivisionTextbox.DataSource = subdivisionTB;
                this.SubdivisionTextbox.DisplayMember = "SubdivisionName";
                this.SubdivisionTextbox.ValueMember = "SubdivisionName";


                SqlCommand cmd3 = new SqlCommand("SELECT concat(PositionID, ' ', PositionName) as 'PositionName' from PositionOfWorker", connection);

                SqlDataAdapter adapter3 = new SqlDataAdapter(cmd3);
                adapter3.Fill(positionTB);
                this.PositionTextbox.DataSource = positionTB;
                this.PositionTextbox.DisplayMember = "PositionName";
                this.PositionTextbox.ValueMember = "PositionName";

                SqlCommand cmd4 = new SqlCommand("SELECT concat(CategoryID, ' ', CategoryName) as 'CategoryName' from CategoryOfPosition", connection);

                SqlDataAdapter adapter4 = new SqlDataAdapter(cmd4);
                adapter4.Fill(categoryTB);
                this.CategoryOfPositionTextbox.DataSource = categoryTB;
                this.CategoryOfPositionTextbox.DisplayMember = "CategoryName";
                this.CategoryOfPositionTextbox.ValueMember = "CategoryName";
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MovementForm cl = this.Owner as MovementForm;
            cl.movement.ID = Convert.ToInt32(WorkerTextbox.Text.Substring(0, WorkerTextbox.Text.IndexOf(' ')));
            cl.movement.Subdivision = Convert.ToInt32(WorkerTextbox.Text.Substring(0, SubdivisionTextbox.Text.IndexOf(' ')));
            cl.movement.Position = Convert.ToInt32(WorkerTextbox.Text.Substring(0, PositionTextbox.Text.IndexOf(' ')));
            cl.movement.CategoryOfPosition = Convert.ToInt32(WorkerTextbox.Text.Substring(0, CategoryOfPositionTextbox.Text.IndexOf(' ')));
            cl.movement.Salary = Convert.ToDouble(salaryTextbox.Text);
            cl.movement.DateOfStart = DateOfStartTextbox.Text;
            cl.movement.DateOfEnding = DateOfEndingTextbox.Text;
            Close();
        }

    }
}
