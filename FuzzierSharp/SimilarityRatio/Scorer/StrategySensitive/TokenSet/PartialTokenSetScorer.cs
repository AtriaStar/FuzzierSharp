using System;
using FuzzierSharp.SimilarityRatio.Strategy;

namespace FuzzierSharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenSetScorer : TokenSetScorerBase
    {
        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}
