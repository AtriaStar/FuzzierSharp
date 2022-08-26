using System;
using FuzzierSharp.SimilarityRatio.Strategy.Generic;

namespace FuzzierSharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenDifferenceScorer : TokenDifferenceScorerBase
    {
        protected override Func<string[], string[], int> Scorer => PartialRatioStrategy<string>.Calculate;
    }
}
