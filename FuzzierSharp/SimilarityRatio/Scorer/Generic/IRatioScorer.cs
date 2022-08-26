using System;

namespace FuzzierSharp.SimilarityRatio.Scorer.Generic
{
    public interface IRatioScorer<in T> where T : IEquatable<T>
    {
        int Score(T[] input1, T[] input2);
    }
}
