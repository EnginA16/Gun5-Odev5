using Gun5_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Abstract
{
    public interface ISaleManager
    {
        void Sale(Game game, Customer customer);
        bool WinterSale(Game game, Customer customer);
        bool SummerSale(Game game, Customer customer);
    }
}
