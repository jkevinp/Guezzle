using UnityEngine;
using System.Collections;

public class Puzzle{
    public int row = 0 , col =0;
    public Puzzle[,] puzzlePieces;
    public Puzzle(int _row, int _col )
    {
        row = _row;
        col = _col;
        puzzlePieces = new Puzzle[row, col];
    }
}
