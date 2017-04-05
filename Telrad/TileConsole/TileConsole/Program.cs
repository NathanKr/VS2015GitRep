using System;
namespace TileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double fTileWidth = 10.1, fTileHeight = 20.2, fTileArea;
            Tile1 tile = new Tile1(fTileWidth, fTileHeight); // יצירת אוביקט של מחלקה ;

            fTileArea = tile.ComputeArea();
            Console.WriteLine("area : {0}", fTileArea);
            Console.ReadLine();
        }
    }
}
