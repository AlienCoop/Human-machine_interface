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
    [Table("MovementOnJobHistory")]
    public class Movement
    {
        public int ID { get; set; }
        public int Subdivision { get; set; }
        public int Position { get; set; }
        public int CategoryOfPosition { get; set; }
        public int PreviousPosition { get; set; }
        public double Salary { get; set; }
        public string DateOfStart { get; set; }
        public string DateOfEnding { get; set; }


        static public void InsertMovement(Movement movement, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("InsertMovement", connection);
                AddCommand(command, movement);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        static public void UpdateMovement(Movement movement, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("UpdateMovement", connection);
                
                AddCommand(command, movement);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        static public void DeleteMovement(List<int> IDs)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                foreach (int id in IDs)
                {
                    SqlCommand command = new SqlCommand("delete from dbo.MovementOnJobHistory where ID = @ID", connection);
                    command.Parameters.Add(new SqlParameter("@ID", id));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private static void AddCommand(SqlCommand command, Movement movement)
        {
            command.Parameters.Add(new SqlParameter("@ID", movement.ID));
            command.Parameters.Add(new SqlParameter("@Subdivision", movement.Subdivision));
            command.Parameters.Add(new SqlParameter("@Position", movement.Position));
            command.Parameters.Add(new SqlParameter("@CategoryOfPosition", movement.CategoryOfPosition));
            command.Parameters.Add(new SqlParameter("@PreviousPosition", movement.PreviousPosition));
            command.Parameters.Add(new SqlParameter("@Salary", movement.Salary));
            command.Parameters.Add(new SqlParameter("@DateOfStart", movement.DateOfStart));
            


        }
    }
}
