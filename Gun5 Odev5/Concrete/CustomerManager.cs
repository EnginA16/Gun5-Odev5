using Gun5_Odev5.Abstract;
using Gun5_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Concrete
{
    class CustomerManager : ICustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("{0} {1} adlı müşteri eklendi.", customer.FirstName,customer.LastName);
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("{0} {1} adlı müşteri silindi.", customer.FirstName, customer.LastName);
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("{0} {1} adlı müşteri güncellendi.", customer.FirstName, customer.LastName);
        }
    }
}
