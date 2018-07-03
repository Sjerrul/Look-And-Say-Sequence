using System;
using System.Collections.Generic;
using System.Linq;

namespace Sjerrul.ConwaysRow.Generator
{
    /// <summary>
    /// Class able to split strings in various ways
    /// </summary>
    public static class StringSplitter
    {
        /// <summary>
        /// Recursively splits the input in groups of characters that are the same and follow
        /// eachother. 
        /// Ie. "11" => ["11"]
        ///     "1122" => ["11", "22"]
        ///     "121" => ["1", "2", "1"]
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>The list of groups</returns>
        /// <exception cref="System.ArgumentNullException">input</exception>
        public static IList<string> SplitInGroups(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            IList<string> groups = new List<string>();

            while (input.Length != 0)
            {
                char currentCheckingCharacter = input.First();

                string group = new string(input.TakeWhile(c => c == currentCheckingCharacter).ToArray());
                groups.Add(group);

                input = input.Substring(group.Length);
            }

            return groups;
        }
    }
}
