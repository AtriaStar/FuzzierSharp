using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FuzzySharp.PreProcess
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
