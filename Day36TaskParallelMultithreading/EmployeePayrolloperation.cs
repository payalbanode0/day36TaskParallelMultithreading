using System;
using System.Collections.Generic;
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
                Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                this.addEmployeeToPayroll(employeeData);
                Console.WriteLine("Employee added : " + employeeData.EmployeeName);
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

                    Console.WriteLine("Employee Being Added :" + employeeData.EmployeeName);
                    this.addEmployeeToPayroll(employeeData);
                    Console.WriteLine("Employee added : " + employeeData.EmployeeName);
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