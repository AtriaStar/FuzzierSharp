using System;
using FuzzierSharp.SimilarityRatio.Strategy.Generic;

namespace FuzzierSharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenDifferenceScorer : TokenDifferenceScorerBase
    {
        protected override Func<string[], string[], int> Scorer => DefaultRatioStrategy<string>.Calculate;
    }
}
