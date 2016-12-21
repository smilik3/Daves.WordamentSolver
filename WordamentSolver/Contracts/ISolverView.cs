﻿using System;
using System.Collections.Generic;
using WordamentSolver.Models;

namespace WordamentSolver.Contracts
{
    public interface ISolverView
    {
        int BoardWidth { get; }
        int BoardHeight { get; }

        event Action<int?> SortBySelectionChanged;
        event Action SolveWithTilePointsGuess;
        event Action Solve;
        event Action<int?> WordSelectionChanged;
        event Action ClearPath;
        event Action ClearBoard;
        event Action<string> SaveToFile;
        event Action<string> LoadFromFile;

        void DisplaySortByOptions(IReadOnlyList<WordSorter> wordSorters, int selectedIndex);
        void DisplayBoard(Board board);
        Board GetBoard();
        void DisplaySolution(Solution solution);
        void DisplayPath(Word word);
    }
}
