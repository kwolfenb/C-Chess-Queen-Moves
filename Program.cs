using System;
using System.Collections.Generic;
using Chess;

namespace Chess
{
    public class Program
    {
        public static void Main()
        {
        Console.WriteLine("Enter the coordinates to place the queen on the board.");
        Console.WriteLine("What is the X coordinate?");
        int queenX = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the Y coordinate?");
        int queenY = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the x coordinate of the space to attack?");
        int spaceX = int.Parse(Console.ReadLine());
        Console.WriteLine("What is the y coordinate of the space to attack?");
        int spaceY = int.Parse(Console.ReadLine());
        

        ChessClass chessGame = new ChessClass(queenX, queenY, spaceX, spaceY);
        {
            chessGame.IsAttackable(queenX, queenY, spaceX, spaceY);
        }
        }
    }
}