using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Human_machine_interface.Backend;
using System.Data.SqlClient;
using System.Data;

namespace Human_machine_interface.Entities
{
    [Table("Worker")]
    public class Patient
    {

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int Gender { get; set; }

        public string Birthday { get; set; }

        public int Eductation { get; set; }

        public int MaritalStatus { get; set; }

      



        static public void InsertWorker(Patient patient, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("InsertWorker", connection);
                AddCommand(command, patient);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static public void UpdateWorker(Patient patient, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("UpdateWorker", connection);
                command.Parameters.Add(new SqlParameter("@ID", patient.Id));
                AddCommand(command, patient);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static public void DeleteClient(List<int> IDs)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                foreach (int id in IDs)
                {
                    SqlCommand command = new SqlCommand("delete from dbo.worker where ID = @ID", connection);
                    command.Parameters.Add(new SqlParameter("@ID", id));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private static void AddCommand(SqlCommand command, Patient patient)
        {
            command.Parameters.Add(new SqlParameter("@Name", patient.FirstName));
            command.Parameters.Add(new SqlParameter("@Surname", patient.LastName));
            command.Parameters.Add(new SqlParameter("@Gender", patient.Gender));
            command.Parameters.Add(new SqlParameter("@Birthday", patient.Birthday));
            command.Parameters.Add(new SqlParameter("@Education", patient.Eductation));
            command.Parameters.Add(new SqlParameter("@MaritalStatus", patient.MaritalStatus));
            
        }
    }

}
