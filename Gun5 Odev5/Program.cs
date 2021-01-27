using Gun5_Odev5.Abstract;
using Gun5_Odev5.Concrete;
using Gun5_Odev5.Entities;
using System;

namespace Gun5_Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Engin", LastName = "Aydın", TcNo = "1234567890" };

            Game game1 = new Game() { Id = 1, GameName = "Stellaris", Price = 59.00, ReleaseYear = "2016", ReviewScore = 86 };

            CustomerCheckManager customerCheckManager = new CustomerCheckManager();
            CustomerManager customerManager = new CustomerManager();


            if (customerCheckManager.CustomerCheck(customer1))
            {
                customerManager.Add(customer1);
            }
            else
            {
                Console.WriteLine("Tc Kimlik No Geçersiz!");
            }


            GameManager gameManager = new GameManager();
            SaleManager saleManager = new SaleManager();


            gameManager.Add(game1);

            if (saleManager.SummerSale(game1,customer1))
            {
                saleManager.Sale(game1, customer1);
            }
            else if (saleManager.WinterSale(game1,customer1))
            {
                saleManager.Sale(game1, customer1);
            }
            else
            {
                saleManager.Sale(game1, customer1);
            }
        }
    }
}
