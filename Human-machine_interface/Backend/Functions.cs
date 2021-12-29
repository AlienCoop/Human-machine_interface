using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human_machine_interface.Backend
{
    class Functions
    {
        static public DataTable PatientsSelectAll()
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {

                SqlCommand command = new SqlCommand("WorkerUpdate", connection);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                return dt;

            }
        }

        static public DataTable DiseaseSelectAll()//DataGridView dataGridView1
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {

                SqlCommand command = new SqlCommand("DiseaseUpdate", connection);
                command.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                return dt;
            }
        }
        static public DataTable VaccinationSelectAll()
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {

                SqlCommand command = new SqlCommand("VaccinationUpdate", connection);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                return dt;

            }
        }
        static public DataTable MeterageSelectAll()
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {

                SqlCommand command = new SqlCommand("MeterageUpdate", connection);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                return dt;

            }
        }
        static public DataTable MovementSelectAll()
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {

                SqlCommand command = new SqlCommand("MovementUpdate", connection);


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                return dt;

            }
        }

        static public DataTable CheckVaccination(int id, string StartDate, string EndDate)
        {
            SqlConnection connection = DBConnection.GetDBConnection();
            using (connection)
            {
                connection.Open();
                SqlCommand command = new SqlCommand("CheckVaccination", connection);
                command.Parameters.Add(new SqlParameter("@IDVaccination", id));
                command.Parameters.Add(new SqlParameter("@StartDate", StartDate));
                command.Parameters.Add(new SqlParameter("@EndDate", EndDate));
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                command.CommandType = CommandType.StoredProcedure;

                command.ExecuteNonQuery();

                DataTable dt = new DataTable();

                adapter.Fill(dt);
                connection.Close();
                return dt;
               
            }
        }
    }
}


