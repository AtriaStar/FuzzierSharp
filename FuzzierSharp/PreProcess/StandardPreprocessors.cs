namespace FuzzierSharp.PreProcess
{
    public static class StandardPreprocessors
    {
        private class NonePreprocessor : IPreprocessor
        {
            public string Preprocess(string str) => str;
        }

        private class CaseInsensitivePreprocessor : IPreprocessor
        {
            public string Preprocess(string str) =>
                str.ToLowerInvariant();
        }

        public static IPreprocessor None { get; } = new NonePreprocessor();

        public static IPreprocessor CaseInsensitive { get; } = new CaseInsensitivePreprocessor();

        public static IPreprocessor Full { get; } = new MultiPreprocessor(new Preprocessor(
            new Preprocessor.Range('a', 'z'),
            new Preprocessor.Range('A', 'Z'),
            new Preprocessor.Range('0', '9')
        ), CaseInsensitive);
    }
}
