using System.Text;

namespace FuzzierSharp.PreProcess
{
    public class Preprocessor : IPreprocessor
    {
        public struct Range
        {
            public char From { get; set; }
            public char To { get; set; }

            public Range(char from, char to)
            {
                From = from;
                To = to;
            }
        }

        private readonly Range[] _keepCharRanges;

        public Preprocessor(params Range[] keepCharRanges)
        {
            _keepCharRanges = keepCharRanges;
        }

        public string Preprocess(string str)
        {
            var builder = new StringBuilder(str.Length);
            foreach (var ch in str)
            {
                    var succ = false;
                    foreach (var range in _keepCharRanges)
                    {
                        if (ch >= range.From && ch <= range.To)
                        {
                            builder.Append(ch);
                            succ = true;
                            break;
                        }
                    }
                    if (!succ)
                    {
                        builder.Append(' ');
                    }
            }
            return builder.ToString();
        }
    }
}
