using System;
using System.Collections.Generic;

namespace Ludo
{
    public class Player
    {
        private int startValue;
        public static int Players = 0;

        public List<Pawn> Pawns = new List<Pawn>();
        public enum Color
        {
            Red,
            Green,
            Yellow,
            Blue
        }
        public Color color;

        public int StartValue
        {
            get { return startValue; }
            set { startValue = value; }
        }
       
        public Player()
        {
            Players++;
            switch (Players)
            {
                case 1:
                    color = Color.Red;
                    break;
                case 2:
                    color = Color.Yellow;
                    break;
                case 3:
                    color = Color.Green;
                    break;
                case 4:
                    color = Color.Blue;
                    break;
                case 5:
                    throw new Exception("Too many players. Only 4 allowed");
            }
            Dice d = new Dice();
            startValue = d.Roll();
            Pawn Pawn1 = new Pawn();
            Pawns.Add(Pawn1);
            Pawn Pawn2 = new Pawn();
            Pawns.Add(Pawn2);
            Pawn Pawn3 = new Pawn();
            Pawns.Add(Pawn3);
            Pawn Pawn4 = new Pawn();
            Pawns.Add(Pawn4);
        }

    }
}
