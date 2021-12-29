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
    public partial class AddAndEditPatient : Form
    {
        public AddAndEditPatient()
        {
            InitializeComponent();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                PatientForm cl = this.Owner as PatientForm;
                cl.patient.FirstName = NameTextbox.Text;
                cl.patient.LastName = SurnameTextbox.Text;
                string temp0 = GenderTextbox.Text.ToLower();
                string temp1 = StatusTextbox.Text.ToLower();
                string temp2 = EducationTextbox.Text.ToLower();
                switch (temp0)
                {
                    case "муж":
                        if (temp0 == "муж")
                            cl.patient.Gender = 1;
                        break;
                    case "жен":
                        if (temp0 == "жен")
                            cl.patient.Gender = 2;
                        break;
                }

                cl.patient.Birthday = DateTextBox.Text;

                switch (temp1)
                {
                    case "не женат":
                        if (temp1 == "не женат")
                            cl.patient.MaritalStatus = 1;
                        break;
                    case "разведен":
                        if (temp1 == "разведен")
                            cl.patient.MaritalStatus = 2;
                        break;
                    case "женат":
                        if (temp1 == "женат")
                            cl.patient.MaritalStatus = 3;
                        break;
                    case "гражданский брак":
                        if (temp1 == "гражданский брак")
                            cl.patient.MaritalStatus = 4;
                        break;
                    case "замужем":
                        if (temp1 == "замужем")
                            cl.patient.MaritalStatus = 5;
                        break;
                    case "разведена":
                        if (temp1 == "разведена")
                            cl.patient.MaritalStatus = 6;
                        break;
                }

                switch (temp2)
                {
                    case "высшее":
                        if (temp2 == "высшее")
                            cl.patient.Eductation = 1;
                        break;
                    case "среднее":
                        if (temp2 == "среднее")
                            cl.patient.Eductation = 2;
                        break;
                    case "без образования":
                        if (temp2 == "без образования")
                            cl.patient.Eductation = 3;
                        break;
                }
            }
            catch
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
   
            Close();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        public void SetTBs(DataGridViewRow row)
        {
            NameTextbox.Text = row.Cells[1].Value.ToString();
            SurnameTextbox.Text = row.Cells[2].Value.ToString();
            GenderTextbox.Text = row.Cells[3].Value.ToString();
            DateTextBox.Text = row.Cells[4].Value.ToString();
            EducationTextbox.Text = row.Cells[5].Value.ToString();
            StatusTextbox.Text = row.Cells[6].Value.ToString();
        }
    }
}
