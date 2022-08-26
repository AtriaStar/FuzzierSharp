using System;
using FuzzierSharp.SimilarityRatio.Strategy;

namespace FuzzierSharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class TokenInitialismScorer : TokenInitialismScorerBase
    {
        protected override Func<string, string, int> Scorer => DefaultRatioStrategy.Calculate;
    }
}
