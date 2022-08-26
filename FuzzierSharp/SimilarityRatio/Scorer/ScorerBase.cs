using System;
using FuzzierSharp.PreProcess;

namespace FuzzierSharp.SimilarityRatio.Scorer
{
    public abstract class ScorerBase : IRatioScorer
    {
        public abstract int Score(string input1, string input2);

        public int Score(string input1, string input2, IPreprocessor preprocessor)
        {
            input1 = preprocessor.Preprocess(input1);
            input2 = preprocessor.Preprocess(input2);
            return Score(input1, input2);
        }
    }
}
