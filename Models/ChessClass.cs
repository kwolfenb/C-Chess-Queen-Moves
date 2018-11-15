using System;
using System.Collections.Generic;


namespace Chess
{
    class ChessClass
    {
        public int XCoordinate;
        public int YCoordinate;
        public int QueenXCoordinate;
        public int QueenYCoordinate;

    public ChessClass(int x, int y, int queenx, int queeny)
        {
            XCoordinate= x;
            YCoordinate = y;
            QueenXCoordinate = queenx;
            QueenYCoordinate = queeny;
        }
    public bool IsAttackable(int x, int y, int queenx, int queeny) 
    {
    if ((1 <=x && x<= 8) && (1 <=y && y<= 8) && (1 <= queenx && queenx <= 8)  && (1 <= queeny && queeny <= 8 ))
        {
        if ((x==queenx) || (y==queeny))
        {
            Console.WriteLine("This space can be attacked.");
            return (true); 
        } 
        if (Math.Abs(x-queenx) == Math.Abs(y-queeny))
        {
            Console.WriteLine("This space can be attacked.");
            return true;
        }
        else 
        {
            Console.WriteLine("This space can not be attacked.");
        return (false);
        }
    }
    else  
    {
        Console.WriteLine("This space is not on the Board.");
        return (false);
    }
    }
  }
}