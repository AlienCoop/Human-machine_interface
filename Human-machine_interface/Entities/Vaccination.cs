using Human_machine_interface.Backend;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Human_machine_interface.Entities
{
    [Table("VaccinationOfWorker")]
    public class Vaccination
    {
        
        public int IDworker { get; set; }

        public int IDVaccination { get; set; }

        public string DateOfVactination { get; set; }



        static public void InsertVaccination(Vaccination vaccination, DataGridView dgv)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                //foreach (DataGridViewRow row in dgv.Rows)
                //{
                //    if ((string)row.Cells[2].Value == patient.FirstName && (string)row.Cells[3].Value == patient.LastName)
                //    {
                //        MessageBox.Show("Клиент с таким именем и фамилией уже есть в базе", "Ошибка");
                //        return;
                //    }

                //}
                SqlCommand command = new SqlCommand("InsertVaccination", connection);
                AddCommand(command, vaccination);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static public void UpdateVaccination(Vaccination vaccination, DataGridView dgv)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                //foreach (DataGridViewRow row in dgv.Rows)
                //{
                //    if ((string)row.Cells[2].Value == patient.FirstName && (string)row.Cells[3].Value == patient.LastName)
                //    {
                //        MessageBox.Show("Клиент с таким именем и фамилией уже есть в базе", "Ошибка");
                //        return;
                //    }
                //}
                SqlCommand command = new SqlCommand("UpdateVaccination", connection);
                command.Parameters.Add(new SqlParameter("@IDworker", vaccination.IDworker));
                AddCommand(command, vaccination);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static public void DeleteVaccination(List<int> IDs)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                foreach (int id in IDs)
                {
                    SqlCommand command = new SqlCommand("delete from dbo.VaccinationOfWorker where IDworker = @IDworker", connection);
                    command.Parameters.Add(new SqlParameter("@IDworker", id));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        
        private static void AddCommand(SqlCommand command, Vaccination vaccination)
        {
            
            command.Parameters.Add(new SqlParameter("@IDVaccination", vaccination.IDVaccination));
            command.Parameters.Add(new SqlParameter("@DateOfVactination", vaccination.DateOfVactination));


        }

    }
}
