using System;

namespace Solution
{
    static class Kata
    {
        public static bool SpeakEnglish(string sentence) => sentence.Contains("english", StringComparison.OrdinalIgnoreCase);
    }
}