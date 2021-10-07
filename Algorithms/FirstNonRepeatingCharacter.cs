namespace Algorithms
{
    public static class FirstNonRepeatingCharacter
    {
        /// <summary>
        /// Returns the first non-repeating character in the given <see cref="value"/> string. If all characters are repeating, returns '_'
        /// </summary>
        /// <param name="value">
        /// Any non-empty string of lowercase english letters (a,b,c,...,y,z). No digits, special characters, uppercase, etc. 
        /// </param>
        /// <example>
        /// Find("abc") = 'a' // all characters are non-repeating, 'a' is the first
        /// </example>
        /// <example>
        /// Find("aaabccccdeeeef") = 'b' // b, d, f are non-repeating, 'b' is the first
        /// </example>
        /// <example>
        /// Find("abcabcabc") = '_' // all characters are repeating
        /// </example>
        /// <questions>
        /// - Implement the algorithm
        /// - What is the time complexity
        /// </questions>
        public static char Find(string value)
        {
            return '_';
        }
    }
}