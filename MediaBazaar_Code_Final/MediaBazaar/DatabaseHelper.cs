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


        public static void AddNewUser(string username, string email, String gender, double hourlyWage, string address, string phoneNumber, double hoursWorked, string password, int holidayDays, int sickDays, DateTime birthDate, String department, int maxMonthlyHours)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "INSERT INTO users(username,email,gender,hourlyWage,address,phoneNumber,hoursWorked,password,holidayDays,sickDays,birthDate, department, maxMonthlyHours) " +
                    "VALUES(@username,@email,@gender,@hourlyWage,@address,@phoneNumber,@hoursWorked,@password,@holidayDays,@sickDays,@birthDate, @department, @maxMonthlyHours)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@hoursWorked", hoursWorked);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@holidayDays", holidayDays);
                cmd.Parameters.AddWithValue("@sickDays", sickDays);
                cmd.Parameters.AddWithValue("@birthDate", birthDate);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@maxMonthlyHours", maxMonthlyHours);
                conn.Open();
                cmd.ExecuteNonQuery();
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
        }

        public static void UpdateExistingEmployee(int id, string username, string password, string email, String gender,
            string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, string department, int maxMonthlyHours)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE users SET username = @username, email = @email, holidayDays = @holidayDays, sickDays = @sickDays, birthDate = @birthDate, " +
                    "gender = @gender, hourlyWage = @hourlyWage, address = @address, phoneNumber = @phoneNumber, hoursWorked = @hoursWorked, password = @password, department = @department, maxMonthlyHours = @maxMonthlyHours WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@hoursWorked", hoursWorked);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@holidayDays", holidayDays);
                cmd.Parameters.AddWithValue("@sickDays", sickDays);
                cmd.Parameters.AddWithValue("@birthDate", birthDate);
                cmd.Parameters.AddWithValue("@department", department);
                cmd.Parameters.AddWithValue("@maxMonthlyHours", maxMonthlyHours);
                conn.Open();
                cmd.ExecuteNonQuery();
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
        }

        public static bool DeleteExistingUser(int id)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM users WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
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

                    employees.Add(new Employee(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, department, maxMonthlyHours));
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

        // --PRODUCTS --

        public static void AddProduct(String name, String category, double price, String description, int quantity, String distributor, String emailDistributor, String phoneNrDistributor, int quantSold)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "INSERT INTO products(name,category,price,description,quantity,distribuitor,emailDistribuitor,phoneNrDistribuitor, quantSold) " +
                    "VALUES(@name,@category,@price,@description,@quantity,@distribuitor,@emailDistribuitor,@phoneNrDistribuitor, @quantSold)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@distribuitor", distributor);
                cmd.Parameters.AddWithValue("@emailDistribuitor", emailDistributor);
                cmd.Parameters.AddWithValue("@phoneNrDistribuitor", phoneNrDistributor);
                cmd.Parameters.AddWithValue("@quantSold", quantSold);
                conn.Open();
                cmd.ExecuteNonQuery();
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
        }

        public static void UpdateExistingProduct(int id, string name, string category, double price, string description,
            int quantity, string distributor, string emailDistributor, string phoneNrDistributor, int quantSold)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE products SET name = @name, category = @category, price = @price, description = @description, quantity = @quantity, " +
                    "distribuitor = @distribuitor, emailDistribuitor = @emailDistribuitor, phoneNrDistribuitor = @phoneNrDistribuitor, quantSold = @quantSold WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@distribuitor", distributor);
                cmd.Parameters.AddWithValue("@emailDistribuitor", emailDistributor);
                cmd.Parameters.AddWithValue("@phoneNrDistribuitor", phoneNrDistributor);
                cmd.Parameters.AddWithValue("@quantSold", quantSold);
                conn.Open();
                cmd.ExecuteNonQuery();

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
        }
        public static bool DeleteExistingProduct(int id)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM products WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
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

        public static List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM products";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String name = reader[1].ToString();
                    String category = reader[2].ToString();
                    double price = Convert.ToDouble(reader[3]);
                    String description = reader[4].ToString();
                    int quantity = Convert.ToInt32(reader[5]);
                    String distributor = reader[6].ToString();
                    String emailDistributor = reader[7].ToString();
                    String phoneNrDistributor = reader[8].ToString();
                    int quantSold = Convert.ToInt32(reader[9]);

                    products.Add(new Product(id, name, category, price, description, quantity, distributor, emailDistributor, phoneNrDistributor, quantSold));
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
            return products;
        }

        // --FREE DAYS --

        public static List<FreeDay> GetAllFreeDays()
        {
            List<FreeDay> freeDays = new List<FreeDay>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM free_days";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String name = reader[1].ToString();
                    String email = reader[2].ToString();
                    DateTime date = Convert.ToDateTime(reader[3]);
                    String shift = reader[4].ToString();
                    String reason = reader[5].ToString();
                    bool sick_day = Convert.ToBoolean(reader[6]);
                    String status = reader[7].ToString();

                    freeDays.Add(new FreeDay(id, name, email, date, shift, reason, sick_day, status));
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
            return freeDays;
        }

        public static bool UpdateExistingFreeDay(int id, String name, String email, DateTime date, String shift, String reason, bool sick_day, String status)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE free_days SET id = @id, name = @name, email = @email, date = @date, shift = @shift, reason = @reason, sick_day = @sick_day, status = @status WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@sick_day", sick_day);
                cmd.Parameters.AddWithValue("@status", status);
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

        public static bool DeleteFreeDayRequest(int id, String name, String email, DateTime date, String shift, String reason, bool sick_day, String status)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM free_days WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@reason", reason);
                cmd.Parameters.AddWithValue("@sick_day", sick_day);
                cmd.Parameters.AddWithValue("@status", status);
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

        // --MANAGERS --
        public static List<Manager> GetAllManagers()
        {
            List<Manager> managers = new List<Manager>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM managers";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String name = reader[1].ToString();
                    String password = reader[2].ToString();
                    String email = reader[3].ToString();
                    String gender = reader[4].ToString();
                    String phoneNumber = reader[5].ToString();
                    String address = reader[6].ToString();
                    double hourlyWage = Convert.ToDouble(reader[7]);
                    double hoursWorked = Convert.ToDouble(reader[8]);
                    DateTime birthDate = Convert.ToDateTime(reader[9]);
                    int holidayDays = Convert.ToInt32(reader[10]);
                    int sickDays = Convert.ToInt32(reader[11]);
                    String position = reader[12].ToString();

                    if(position == "inventory manager")
                    {
                        managers.Add(new InventoryManager(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, position));
                    }
                    else
                    {
                        managers.Add(new EmployeeManager(id, name, password, email, gender, phoneNumber, address, hourlyWage, hoursWorked, birthDate, holidayDays, sickDays, position));
                    }

                    
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
            return managers;
        }

        public static void UpdateExistingManager(int id, string name, string password, string email, String gender,
            string phoneNumber, string address, double hourlyWage, double hoursWorked, DateTime birthDate, int holidayDays, int sickDays, String position)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE managers SET id = @id, name = @username, email = @email, holidayDays = @holidayDays, sickDays = @sickDays, birthDate = @birthDate, " +
                    "gender = @gender, hourlyWage = @hourlyWage, address = @address, phoneNumber = @phoneNumber, hoursWorked = @hoursWorked, password = @password, position = @position WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@username", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@hourlyWage", hourlyWage);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@hoursWorked", hoursWorked);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@holidayDays", holidayDays);
                cmd.Parameters.AddWithValue("@sickDays", sickDays);
                cmd.Parameters.AddWithValue("@birthDate", birthDate);
                cmd.Parameters.AddWithValue("@position", position);
                conn.Open();
                cmd.ExecuteNonQuery();
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
        }

        // --STOCK REQUESTS --
        public static List<RestockRequest> GetAllStockRequests()
        {
            List<RestockRequest> restockRequests = new List<RestockRequest>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM restock_requests";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    int idP = Convert.ToInt32(reader[1]);
                    int quantity = Convert.ToInt32(reader[2]);
                    DateTime date = Convert.ToDateTime(reader[3]);
                    String status = reader[4].ToString();
                    restockRequests.Add(new RestockRequest(id, idP, quantity, date, status));
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
            return restockRequests;
        }

        public static void UpdateRestockRequest(int id, String status)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE restock_requests SET status = @status WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                conn.Open();
                cmd.ExecuteNonQuery();

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

        }

        public static bool DeleteStockRequest(int id)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM restock_requests WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
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

        // --SHIFTS --
        public static void AddShift(String name, String email, DateTime date, String shift)
        {
            MySqlConnection conn = null;
            string employeeStatus = "";

            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                employeeStatus = "NA";
                string sql = "INSERT INTO shifts(name, email, date, shift, employeeStatus) " +
                    "VALUES(@name, @email, @date, @shift, @employeeStatus)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@shift", shift);
                cmd.Parameters.AddWithValue("@employeeStatus", employeeStatus);
                conn.Open();
                cmd.ExecuteNonQuery();

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
        }

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

                    shifts.Add(new Shift(id, name, email, date, shift, employeeStatus));
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

        public static bool DeleteExistingShift(int id, String name, String email, DateTime date, String shift, String employeeStatus)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM shifts WHERE id = @id";
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

        // --DEPARTMENTS --
        public static void AddDepartment(String name, int requiredPersonel)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "INSERT INTO departments(name, requiredPersonel) " +
                    "VALUES(@name, @requiredPersonel)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@requiredPersonel", requiredPersonel);
                conn.Open();
                cmd.ExecuteNonQuery();

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
        }

        public static List<Department> GetAllDepartments()
        {
            List<Department> departments = new List<Department>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM departments";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String name = reader[0].ToString();
                    int requiredPersonel = Convert.ToInt32(reader[1]);

                    departments.Add(new Department(name, requiredPersonel));
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
            return departments;
        }


        public static bool DeleteExistingDepartment(String name, int personel)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM departments WHERE name = @name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@personel", personel);
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

        public static bool UpdateExistingDepartment(String name, int requiredPersonel)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE departments SET name = @name, requiredPersonel = @requiredPersonel WHERE name = @name";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@requiredPersonel", requiredPersonel);
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

        public static List<PrefferedShift> GetAllPrefferedShifts()
        {
            List<PrefferedShift> allPrefferedShifts = new List<PrefferedShift>();
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "SELECT * FROM preffered_shifts";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader[0]);
                    String emailEmployee = reader[1].ToString();
                    String monday = reader[2].ToString();
                    String tuesday = reader[3].ToString();
                    String wednesday = reader[4].ToString();
                    String thursday = reader[5].ToString();
                    String friday = reader[6].ToString();

                    List<String> prefferences = new List<string>();
                    prefferences.Add(monday);
                    prefferences.Add(tuesday);
                    prefferences.Add(wednesday);
                    prefferences.Add(thursday);
                    prefferences.Add(friday);

                    allPrefferedShifts.Add(new PrefferedShift(id, emailEmployee, prefferences));
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
            return allPrefferedShifts;
        }
        public static bool UpdatePrefferedShifts(String emailEmployee, List<String> newPreffered)
        {
            MySqlConnection conn = null;
            try
            {
                String monday = newPreffered[0];
                String tuesday = newPreffered[1];
                String wednesday = newPreffered[2];
                String thursday = newPreffered[3];
                String friday = newPreffered[4];


                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "UPDATE preffered_shifts SET monday = @monday, tuesday = @tuesday, wednesday = @wednesday, thursday = @thursday, friday = @friday WHERE emailEmployee = @emailEmployee";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emailEmployee", emailEmployee);
                cmd.Parameters.AddWithValue("@monday", monday);
                cmd.Parameters.AddWithValue("@tuesday", tuesday);
                cmd.Parameters.AddWithValue("@wednesday", wednesday);
                cmd.Parameters.AddWithValue("@thursday", thursday);
                cmd.Parameters.AddWithValue("@friday", friday);
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

        public static void AddPrefferedShifts(String emailEmployee)
        {
            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "INSERT INTO preffered_shifts(emailEmployee, monday, tuesday, wednesday, thursday, friday) " +
                    "VALUES(@emailEmployee, @monday, @tuesday, @wednesday, @thursday, @friday )";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emailEmployee", emailEmployee);
                cmd.Parameters.AddWithValue("@monday", "no preference");
                cmd.Parameters.AddWithValue("@tuesday", "no preference");
                cmd.Parameters.AddWithValue("@wednesday", "no preference");
                cmd.Parameters.AddWithValue("@thursday", "no preference");
                cmd.Parameters.AddWithValue("@friday", "no preference");
                conn.Open();
                cmd.ExecuteNonQuery();

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
        }

        public static bool DeleteExistingPrefferedShifts(String emailEmployee)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(CONNECTION_STRING);
                string sql = "DELETE FROM preffered_shifts WHERE emailEmployee = @emailEmployee";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@emailEmployee", emailEmployee);
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
