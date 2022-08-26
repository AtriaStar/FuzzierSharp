using FuzzierSharp.PreProcess;

namespace FuzzierSharp.SimilarityRatio.Scorer
{
    public interface IRatioScorer
    {
        int Score(string input1, string input2);
        int Score(string input1, string input2, IPreprocessor preprocessor);
    }
}
