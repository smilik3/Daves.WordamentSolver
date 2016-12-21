﻿using System;
using System.Collections.Generic;

namespace WordamentSolver.Models.WordSorters
{
    public sealed class StartLetterByPointsOverWordLengthSorter : WordSorter, IComparer<Word>
    {
        public override string Name => "start letter by: points / word length";

        public int Compare(Word x, Word y)
            => x.StartLetter != y.StartLetter
            ? x.StartLetter.CompareTo(y.StartLetter)
            : WordSorter.PointsOverWordLength.Compare(x, y);

        public override void Sort(Word[] words)
            => Array.Sort(words, comparer: this);
    }
}
