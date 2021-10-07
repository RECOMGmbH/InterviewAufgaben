namespace Algorithms
{
    public static class PairOfIntegersWithGivenSum
    {
        /// <summary>
        /// Tests, if there exists a pair of integers a[i], b[j] with a[i]+b[j] == targetValue
        /// </summary>
        /// <param name="a">Any array of integers of arbitrary size, can be empty (but not null), can contain positive, negative and zero values
        /// (not necessary distinct), needs not to be sorted</param>
        /// <param name="b">Other array like a</param>
        /// <param name="targetValue"></param>
        /// <returns>True, if there exists a pair from array a and b with a[i]+b[j] == targetValue, otherwise False</returns>
        /// <example>
        /// Exists([1,2,3,4,5],
        ///        [10,20,30,40,50],
        ///        42) = true
        /// </example>
        /// <example>
        /// Exists([1,2,3,4,5],
        ///        [10,20,30,40,50],
        ///        17) = false
        /// </example>
        /// <example>
        /// Exists([1,0,0,-3,3457],
        ///        [15,-12,265,40,-5, 6],
        ///        -8) = true
        /// </example>
        /// <questions>
        /// - Implement the algorithm
        /// - What is the time complexity
        /// </questions>
        public static bool Exists(int[] a, int[] b, int targetValue)
        {
            return false;
        }
    }
}