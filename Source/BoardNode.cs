using System;

namespace TileGameAPI;
public class BoardNode{
    internal byte[][] Board;
    internal BoardNode Next;
    internal BoardNode Prev;
    internal byte BX; // x location of blank tile
    internal byte BY; // y location of blank tile
    
    public BoardNode(byte MaxDimension){
        this.Board = new byte[MaxDimension][MaxDimension];
    }

    internal void SwapTile(string swapDirection){
        byte temp;
        switch (swapDirection){
            case "up":    temp = this.Board[BY-1][BX];
                          this.Board[BY-1][BX] = this.Board[BY][BX];
                          this.BY--;
                          break;
            
            case "down":  temp = this.Board[BY+1][BX];
                          this.Board[BY+1][BX] = this.Board[BY][BX];
                          this.Board[BY][BX] = temp;
                          this.BY++;
                          break;
            
            case "left":  temp = this.Board[BY][BX-1];
                          this.Board[BY][BX-1] = this.Board[BY][BX];
                          this.Board[BY][BX] = temp;
                          this.BX--;
                          break;

            case "right": temp = this.Board[BY][BX+1];
                          this.Board[BY][BX+1] = this.Board[BY][BX];
                          this.Board[BY][BX] = temp;
                          this.BX++;
                          break;
        }
    }

    internal void CopyBoard(BoardNode toCopy){
        this.Board = toCopy.Board;
    }

    internal void CopyBlankTileLocation(BoardNode toCopy){
        this.BX = toCopy.BX;
        this.BY = toCopy.BY;
    }

    internal void SetNextBoardNode(BoardNode nextNode){
        this.Next = nextNode;
    }

    internal void SetPrevBoardNode(BoardNode prevNode){
        this.Prev = prevNode;
    }

    public String ToString(BoardNode node){
        //byte i;
        StringBuilder line = new();
        for(byte i = 0; i < node.Board.Length(); i++ ){
            line = "";
            for (byte j = 0; i< node.Board[0].Length(); j++){
                line += $"[{i}][{j}]: {node.Board[i][j]} ";
            }
            Console.WriteLine(line);
        }
    }
}
