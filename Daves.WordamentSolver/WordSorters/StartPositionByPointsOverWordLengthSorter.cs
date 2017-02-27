﻿using System;
using System.Collections.Generic;

namespace Daves.WordamentSolver.WordSorters
{
    public sealed class StartPositionByPointsOverWordLengthSorter : WordSorter, IComparer<Word>
    {
        public override string Name => "start position by: points / word length";

        public int Compare(Word x, Word y)
            => x.StartPosition != y.StartPosition
            ? x.StartPosition.CompareTo(y.StartPosition)
            : WordSorter.PointsOverWordLength.Compare(x, y);

        public override void Sort(Word[] words)
            => Array.Sort(words, comparer: this);
    }
}