using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36TaskParallelMultithreading
{
    public class EnployeePayrollOperations
    {
        public List<EmployeeDetails> employeePolyeeDetailList = new List<EmployeeDetails>();

        //UC 1
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Employee Being Added  :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Time.Stop();
                Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.employeePolyeeDetailList.ToString());
        }
        //UC 2
        public void addEmployeeToPayrollWithThread(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Time.Stop();
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePolyeeDetailList.Count);
        }
        public void addEmployeeToPayroll(EmployeeDetails emp)
        {
            employeePolyeeDetailList.Add(emp);


        }



    }
}