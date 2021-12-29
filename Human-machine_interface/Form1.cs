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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }


        private void HelpButton_Click(object sender, EventArgs e)
        {

        }
        

        private void списокПациентовToolStripMenuItem_Click(object sender, EventArgs e) // пациенты
        {

            PatientForm patients = new PatientForm();
            this.Hide();
            patients.Show();
        }

        
        private void toolStripButton1_Click(object sender, EventArgs e) // заболевания
        {
            Diseases diseases = new Diseases();
            this.Hide();
            diseases.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e) // прививки
        {
            Vaccinations vaccinations = new Vaccinations();
            this.Hide();
            vaccinations.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MeterageForm meterage = new MeterageForm();
            this.Hide();
            meterage.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            MovementForm movement = new MovementForm();
            this.Hide();
            movement.Show();
        }
    }
}
