using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Day36TaskParallelMultithreading;

namespace UnitTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();

            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Bruce", PhoneNumber: "9999999999", Address: "XYZ", Department: "Civil", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2019, 08, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 2, EmployeeName: "Wayne", PhoneNumber: "9999999999", Address: "XYZ", Department: "Mech", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2019, 06, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 3, EmployeeName: "Peter", PhoneNumber: "9999999999", Address: "XYZ", Department: "Electrical", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2020, 08, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 4, EmployeeName: "Parker", PhoneNumber: "9999999999", Address: "XYZ", Department: "CS", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2020, 04, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 5, EmployeeName: "Tony", PhoneNumber: "9999999999", Address: "XYZ", Department: "Electronics", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2018, 08, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 6, EmployeeName: "Stark", PhoneNumber: "9999999999", Address: "XYZ", Department: "IT", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2018, 10, 12), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 7, EmployeeName: "Captain", PhoneNumber: "9999999999", Address: "XYZ", Department: "HR", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2020, 03, 01), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 8, EmployeeName: "Marval", PhoneNumber: "9999999999", Address: "XYZ", Department: "Marketing", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2021, 08, 15), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 9, EmployeeName: "Bruce", PhoneNumber: "9999999999", Address: "XYZ", Department: "Production", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2021, 08, 23), City: "Varanasi", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 10, EmployeeName: "Banner", PhoneNumber: "9999999999", Address: "XYZ", Department: "HR", Gender: 'M', BasicPay: 100000, Deductions: 1000, TaxablePay: 20, Tax: 100, NetPay: 90000, startDate: new System.DateTime(2022, 02, 01), City: "Varanasi", Country: "India"));

            //Uc 1 without Thread
            EnployeePayrollOperations employeePayrollOperations = new EnployeePayrollOperations();

            employeePayrollOperations.addEmployeeToPayroll(employees);

            //Uc 2 With Thread
            employeePayrollOperations.addEmployeeToPayrollWithThread(employees);


        }
        [TestMethod]
        //Test Uc 5
        public void Given10employee_ShowDuration()
        {

            List<PayrollDetails> empPayRoll = new List<PayrollDetails>();
            empPayRoll.Add(new PayrollDetails(EmployeeID: 1, BasicPay: 25000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 24000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 2, BasicPay: 250000, Deductions: 2000, TaxablePay: 2000, Tax: 1000, NetPay: 240000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 3, BasicPay: 20000, Deductions: 200, TaxablePay: 200, Tax: 100, NetPay: 19000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 4, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 5, BasicPay: 500000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 490000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 6, BasicPay: 650000, Deductions: 500, TaxablePay: 1000, Tax: 10000, NetPay: 640000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 7, BasicPay: 50000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 8, BasicPay: 40000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 40000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 9, BasicPay: 460000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 45000));
            empPayRoll.Add(new PayrollDetails(EmployeeID: 10, BasicPay: 550000, Deductions: 300, TaxablePay: 100, Tax: 100, NetPay: 540000));

            //Without Thread
            PayrollOperations payrollOperations = new PayrollOperations();
            payrollOperations.addPayrollWithoutThread(empPayRoll);

            //With Thread
            payrollOperations.addPayrolllWithThread(empPayRoll);
        }
    }
}