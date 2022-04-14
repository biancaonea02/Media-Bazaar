using MediaBazaar.classes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaar
{
    class DatabaseHelper
    {
        public const String CONNECTION_STRING = "Server=studmysql01.fhict.local;Uid=dbi452560;Database=dbi452560;Pwd=12345;";

        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM users";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String name = reader[1].ToString();
                    String email = reader[2].ToString();
                    String gender = reader[3].ToString();
                    double hourlyWage = Convert.ToDouble(reader[4]);
                    String address = reader[5].ToString();
                    String phoneNumber = reader[6].ToString();
                    double hoursWorked = Convert.ToDouble(reader[7]);
                    String password = reader[8].ToString();
                    int holidayDays = Convert.ToInt32(reader[9]);
                    int sickDays = Convert.ToInt32(reader[10]);
                    DateTime birthDate = Convert.ToDateTime(reader[11]);
                    String department = reader[12].ToString();
                    int maxMonthlyHours = Convert.ToInt32(reader[13]);
                    string prefferedShift = reader[14].ToString();

                    employees.Add(new Employee(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, department, maxMonthlyHours, prefferedShift));
                }
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return employees;
        }

        // --SHIFTS --

        public static List<Shift> GetAllShifts()
        {
            List<Shift> shifts = new List<Shift>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM shifts";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String name  = reader[1].ToString();
                    String email = reader[2].ToString();
                    DateTime date = Convert.ToDateTime(reader[3]);
                    String shift = reader[4].ToString();
                    String employeeStatus = reader[5].ToString();

                    shifts.Add(new Shift(id, name, email, date, shift));
                }
            }
            catch (MySqlException ex)
            {

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return shifts;
        }

        public static bool UpdateExistingShift(int id, String name, String email, DateTime date, String shift, String employeeStatus)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE shifts SET id = @id, name = @name, email = @email, date = @date, shift = @shift, employeeStatus = @employeeStatus WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@employeeStatus", employeeStatus);
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error {ex}");
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return false;
        }

    }
}
