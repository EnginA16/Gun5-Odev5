using Gun5_Odev5.Abstract;
using Gun5_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Concrete
{
    public class SaleManager : ISaleManager
    {
        public void Sale(Game game, Customer customer)
        {
            Console.WriteLine("{0} id nolu kullanıcı {1} adlı oyunu satın aldı. Ücret = {2}", customer.Id, game.GameName, game.Price);
        }

        public bool SummerSale(Game game, Customer customer)
        {
            double discount = 0.25;
            game.Price = game.Price * discount;
            return true; //Yaz İndirimi Aktif
        }

        public bool WinterSale(Game game, Customer customer)
        {
            double discount = 0.25;
            game.Price = game.Price * discount;
            return false; //Kış İndirimi Aktif Değil
        }
    }
}
