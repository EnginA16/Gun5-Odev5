using Gun5_Odev5.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Entities
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string ReleaseYear { get; set; }
        public int ReviewScore { get; set; }
    }
}
