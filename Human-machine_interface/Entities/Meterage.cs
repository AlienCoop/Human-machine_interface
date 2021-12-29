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
    [Table("HistoryMeterage")]
    public class Meterage
    {

        public int IDworker { get; set; }

        public float Growth { get; set; }

        public float Weight { get; set; }
        public string DateMeterage { get; set; }


        static public void InsertMeterage(Meterage meterage, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("InsertMeterage", connection);
                AddCommand(command, meterage);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        static public void UpdateMeterage(Meterage meterage, DataGridView dgv)
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
                SqlCommand command = new SqlCommand("UpdateMeterage", connection);
                
                AddCommand(command, meterage);
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        static public void DeleteMeterage(List<int> IDs)
        {
            SqlConnection connection = DBConnection.GetDBConnection();

            using (connection)
            {
                connection.Open();
                foreach (int id in IDs)
                {
                    SqlCommand command = new SqlCommand("delete from dbo.HistoryMeterage where IDworker = @IDworker", connection);
                    command.Parameters.Add(new SqlParameter("@IDworker", id));
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        private static void AddCommand(SqlCommand command, Meterage meterage)
        {
            command.Parameters.Add(new SqlParameter("@IDworker", meterage.IDworker));
            command.Parameters.Add(new SqlParameter("@Growth", meterage.Growth));
            command.Parameters.Add(new SqlParameter("@Weight", meterage.Weight));
            command.Parameters.Add(new SqlParameter("@DateMeterage", meterage.DateMeterage));
        }
    }
}
