using Gun5_Odev5.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Abstract
{
    public interface IGameManager
    {
        void Add(Game game);
        void Update(Game game);
        void Delete(Game game);
    }
}
