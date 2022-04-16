using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day36TaskParallelMultithreading

{
    public class PayrollOperations
    {
        public List<PayrollDetails> PayrollDetailList = new List<PayrollDetails>();

        //UC 5 without Thread
        public void addPayrollWithoutThread(List<PayrollDetails> payrollDataList)
        {
            payrollDataList.ForEach(payrollData =>
            {
                Stopwatch Time = new Stopwatch();
                Time.Start();
                Console.WriteLine("Payment Being Added  :" + payrollData.BasicPay + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay);
                this.addToPayroll(payrollData);
                Time.Stop();
                Console.WriteLine("Payment added : " + payrollData.BasicPay + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay + " ( Duration  : " + Time.Elapsed + ")");
            });
            Console.WriteLine(this.PayrollDetailList.ToString());
        }
        //UC 5, With Thread
        public void addPayrolllWithThread(List<PayrollDetails> payrollDataList)
        {
            payrollDataList.ForEach(payrollData =>
            {
                Task thread = new Task(() =>
                {
                    Stopwatch Time = new Stopwatch();
                    Time.Start();

                    Console.WriteLine("Basic Added  : " + payrollData.BasicPay + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay);
                    this.addToPayroll(payrollData);
                    Time.Stop();
                    Console.WriteLine("Basic added : " + payrollData.BasicPay + ", Deduction Added : " + payrollData.Deductions + " ,TaxablePay Added : " + payrollData.TaxablePay + ", Tax Added : " + payrollData.Tax + ", NetPay Added : " + payrollData.NetPay + " ( Duration : " + Time.Elapsed + ")");
                });
                thread.Start();
            });
            Console.WriteLine(this.PayrollDetailList.Count);
        }

        public void addToPayroll(PayrollDetails pay)
        {
            PayrollDetailList.Add(pay);

        }

    }
}