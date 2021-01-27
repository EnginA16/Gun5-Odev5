using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Abstract
{
    public interface ICustomer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }

    }
}
