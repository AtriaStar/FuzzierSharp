namespace FuzzySharp.PreProcess
{
    internal class CaseInvariantPreprocessor : IPreprocessor
    {
        public string Preprocess(string str) =>
            str.ToLowerInvariant();
    }
}
