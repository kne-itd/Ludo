using System;
namespace Ludo
{
    public class Board
    {
        public int[] Fields = new int[54];

        // Fields[0] = startarea
        // Fields[53-57] = Goalarea
        // Fields[58] = Goal
        public Board()
        {
            for (int i = 0; i < 58; i++)
            {
                Fields[i] = i;
            }
        }
    }
}
