using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Customer
    {
        public Customer()
        {

        }
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess()
        {

        }

        public string GetCustomerName()
        {
            return "CustomerName";
        }
    }

    public class CustomerBusinessLayer
    {
        public CustomerBusinessLayer()
        {

        }

        public void GetCustomerName()
        {
            //DIP Violation and Bad design Code because of tightly coupled code.
            CustomerDataAccess customerDataAccess = new CustomerDataAccess();
            customerDataAccess.GetCustomerName();

            //Partial DIP implementation
            ICustomerDataAccess obj = new CustomerDataAccess();
            obj.GetCustomerName();

            //Do it with Factory 
            ICustomerDataAccess objDip = CustomerDataAccessFactory.GetCustomerName();
            objDip.GetCustomerName();
        }
    }

    public interface ICustomerDataAccess
    {
        string GetCustomerName();
    }

    public class CustomerDataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerName()
        {
            return new CustomerDataAccess();
        } 
    }
}
