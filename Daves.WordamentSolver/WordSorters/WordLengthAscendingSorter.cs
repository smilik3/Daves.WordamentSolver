﻿using System;
using System.Collections.Generic;

namespace Daves.WordamentSolver.WordSorters
{
    public class WordLengthAscendingSorter : WordSorter, IComparer<Word>
    {
        public override string Name => "word length ascending";

        public virtual int Compare(Word x, Word y)
            => x.Length != y.Length
            ? x.Length.CompareTo(y.Length)
            : WordSorter.Alphabet.Compare(x, y);

        public override void Sort(Word[] words)
            => Array.Sort(words, comparer: this);
    }
}
