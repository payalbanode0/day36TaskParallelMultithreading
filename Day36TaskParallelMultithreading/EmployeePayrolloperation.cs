using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Day36TaskParallelMultithreading
{
    public class EmployeePayrollOperations
    {
        /* UC0:- Ability to create a payroll service database and have C# program connect to database.
                - Use the payroll_service database created in MSSQL.
                - Install System.Data.SqlClient Package.
                - Check if the database connection to payroll_service mssql DB is established.
        */

        public static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Payroll_Service;Integrated Security=True"; //Specifying the connection string from the sql server connection.


        SqlConnection connection = new SqlConnection(connectionString); // Establishing the connection using the Sqlconnection.  

        public bool DataBaseConnection()
        {
            try
            {
                DateTime now = DateTime.Now; //create object DateTime class //DateTime.Now class access system date and time 
                connection.Open(); // open connection
                using (connection)  //using SqlConnection
                {
                    Console.WriteLine($"Connection is created Successful {now}"); //print msg

                }
                connection.Close(); //close connection
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }

        /* UC1:- Ability to add multiple employee to payroll DB.
                 - Use the payroll_service database created in MS SQL
                 - Use addEmployeeToPayroll previously created along with ADO.NET Transaction.
                 - Record the start and stop time to essentially determine the time taken for the execution
                 - Use MSTest and TDD approach for all Use Cases.
                 - Ensure every Use Cases is a working code and is committed in GIT.
        */
        public List<EmployeeDetails> employeePayrollDetailList = new List<EmployeeDetails>();
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
            });

            Console.WriteLine(this.employeePayrollDetailList.ToString());
        }

        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollDetailList.Add(emp);
        }

        public bool AddEmployeeToDataBase(EmployeeDetails model)
        {
            try
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand("dbo.SqlProcedureName", this.connection);   //Creating a stored Procedure for adding employees into database

                    command.CommandType = CommandType.StoredProcedure; //Command type is a class to set as stored procedure
                                                                       // Adding values from employeemodel to stored procedure 

                    command.Parameters.AddWithValue("@EmployeeName", model.EmployeeName);
                    command.Parameters.AddWithValue("@PhoneNumber", model.PhoneNumber);
                    command.Parameters.AddWithValue("@Address", model.Address);
                    command.Parameters.AddWithValue("@Department", model.Department);
                    command.Parameters.AddWithValue("@Gender", model.Gender);
                    command.Parameters.AddWithValue("@BasicPay", model.BasicPay);
                    command.Parameters.AddWithValue("@Deductions", model.Deductions);
                    command.Parameters.AddWithValue("@TaxablePay", model.TaxablePay);
                    command.Parameters.AddWithValue("@Tax", model.Tax);
                    command.Parameters.AddWithValue("@NetPay", model.NetPay);
                    command.Parameters.AddWithValue("@StartDate", model.StartDate);
                    command.Parameters.AddWithValue("@City", model.City);
                    command.Parameters.AddWithValue("@Country", model.Country);
                    connection.Open();
                    var result = command.ExecuteNonQuery();
                    connection.Close();

                    if (result != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

    }
}