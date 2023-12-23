using System;
using TileGameAPI;


static void main(){
    const byte MAXD = 4;
    BoardNode test = new BoardNode(MAXD);
    test.Board = new byte[,] {
                                {0x0, 0x1, 0x2},
                                {0x3, 0x4, 0x5},
                                {0x6, 0x7, 0x8}
                              };
    test.BY = 0;
    test.BX = 0;
    test.Next = null;
    test.Prev = null;
    test.SwapTile("right");
    Console.WriteLine(test);

}