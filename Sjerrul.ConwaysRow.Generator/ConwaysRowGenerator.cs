using System;
using System.Collections.Generic;
using System.Text;

namespace Sjerrul.ConwaysRow.Generator
{
    /// <summary>
    /// Generator for generating the Look-and-say-Sequence
    /// </summary>
    /// <seealso cref="Sjerrul.ConwaysRow.Generator.IGenerate" />
    public class ConwaysRowGenerator : IGenerate
    {
        /// <summary>
        /// Generates the next item.
        /// </summary>
        /// <param name="currentItem">The current item.</param>
        /// <returns>
        /// The next item in the sequence, based on the current item
        /// </returns>
        public string GenerateNextItem(string currentItem)
        {
            if (string.IsNullOrWhiteSpace(currentItem))
            {
                throw new ArgumentNullException(nameof(currentItem));
            }

            IList<String> groups = StringSplitter.SplitInGroups(currentItem);

            StringBuilder nextNumber = new StringBuilder();
            foreach (string group in groups)
            {
                char number = group[0];
                int amount = group.Length;

                nextNumber.Append(amount).Append(number);
            }

            return nextNumber.ToString();
        }
    }
}
