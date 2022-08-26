﻿using System;
using FuzzierSharp.SimilarityRatio.Strategy;

namespace FuzzierSharp.SimilarityRatio.Scorer.StrategySensitive
{
    public class PartialTokenSortScorer : TokenSortScorerBase
    {
        protected override Func<string, string, int> Scorer => PartialRatioStrategy.Calculate;
    }
}