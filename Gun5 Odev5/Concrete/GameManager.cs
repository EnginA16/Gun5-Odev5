using Gun5_Odev5.Abstract;
using Gun5_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Concrete
{
    public class GameManager : IGameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("{0} adlı oyun eklendi.", game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("{0} adlı oyun silindi.", game.GameName);
        }
        public void Update(Game game)
        {
            Console.WriteLine("{0} adlı oyun güncellendi.", game.GameName);
        }
    }
}
