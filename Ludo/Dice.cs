using System;
namespace Ludo
{
    public class Dice
    {
        public int Roll()
        {
            var rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
