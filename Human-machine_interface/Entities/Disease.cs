using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_machine_interface.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using System.Data;
    using global::Human_machine_interface.Backend;

    namespace Human_machine_interface.Entities
    {
        [Table("HistoryOfDisease")]
        public class Disease
        {


            [Required]
            [StringLength(50)]
            public int IDworker { get; set; }

            [Required]
            [StringLength(50)]
            public int IDdisease { get; set; }

            public string DateOfStart { get; set; }

            public string DateOfEnding { get; set; }





            static public void InsertDisease(Disease disease, DataGridView dgv)
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
                    SqlCommand command = new SqlCommand("InsertDisease", connection);
                    command.Parameters.Add(new SqlParameter("@IDworker", disease.IDworker));
                    AddCommand(command, disease);
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            static public void UpdateDisease(Disease disease, DataGridView dgv)
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
                    SqlCommand command = new SqlCommand("UpdateDisease", connection);
                    command.Parameters.Add(new SqlParameter("@IDworker", disease.IDworker));
                    AddCommand(command, disease);
                    command.CommandType = CommandType.StoredProcedure;

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            static public void DeleteDisease(List<int> IDs)
            {
                SqlConnection connection = DBConnection.GetDBConnection();

                using (connection)
                {
                    connection.Open();
                    foreach (int id in IDs)
                    {
                        SqlCommand command = new SqlCommand("delete from dbo.HistoryOfDisease where IDWorker = @IDworker", connection);
                        command.Parameters.Add(new SqlParameter("@IDWorker", id));
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
            }

            private static void AddCommand(SqlCommand command, Disease disease)
            {
                command.Parameters.Add(new SqlParameter("@IDdisease", disease.IDdisease));
                command.Parameters.Add(new SqlParameter("@DateOfStart", disease.DateOfStart));
                command.Parameters.Add(new SqlParameter("@DateOfEnding", disease.DateOfEnding));
            }
        }
    }
}

