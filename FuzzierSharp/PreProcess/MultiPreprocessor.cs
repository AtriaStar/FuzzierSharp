using System.Linq;

namespace FuzzierSharp.PreProcess
{
    public class MultiPreprocessor : IPreprocessor
    {
        private readonly IPreprocessor[] _preprocessors;

        public MultiPreprocessor(params IPreprocessor[] preprocessors)
        {
            _preprocessors = preprocessors;
        }

        public string Preprocess(string str) =>
            _preprocessors.Aggregate(str, (current, pre) => pre.Preprocess(current));
    }
}
