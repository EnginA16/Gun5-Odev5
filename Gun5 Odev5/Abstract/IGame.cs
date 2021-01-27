using System;
using System.Collections.Generic;
using System.Text;

namespace Gun5_Odev5.Abstract
{
    public interface IGame
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public string ReleaseYear { get; set; }
        public int ReviewScore { get; set; }
    }
}
