using System;

namespace FuzzierSharp.SimilarityRatio.Scorer.Generic
{
    public abstract class ScorerBase<T> : IRatioScorer<T> where T : IEquatable<T>
    {
        public abstract int Score(T[] input1, T[] input2);
    }
}
