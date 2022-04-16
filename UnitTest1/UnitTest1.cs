using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Day36TaskParallelMultithreading

namespace TestProject1
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
            DateTime StartDateTime = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayroll(employees);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration Without thread: " + (stopDateTime - StartDateTime));

            //Uc 2 With Thread
            DateTime StartDateTimeThread = DateTime.Now;
            employeePayrollOperations.addEmployeeToPayrollWithThread(employees);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration With thread: " + (stopDateTime - StartDateTime));

        }
    }
}