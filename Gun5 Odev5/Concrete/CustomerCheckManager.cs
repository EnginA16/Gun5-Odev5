using System;
using System.Collections.Generic;
using System.Text;
using Gun5_Odev5.Abstract;
using Gun5_Odev5.Entities;

namespace Gun5_Odev5.Concrete
{
    public class CustomerCheckManager : ICustomerCheckManager
    {
        public bool CustomerCheck(Customer customer)
        {
            Console.WriteLine("Kullanıcı E-Devlet sisteminden kontrol ediliyor.");
            return true;
        }
    }
}
