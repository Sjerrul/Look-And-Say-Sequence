using System;

namespace Sjerrul.ConwaysRow.Generator
{
    /// <summary>
    /// Interface for classes implementing a generator that generates a next item based on some input
    /// </summary>
    public interface IGenerate
    {
        /// <summary>
        /// Generates the next item.
        /// </summary>
        /// <param name="currentItem">The current item.</param>
        /// <returns>The next item in the sequence, based on the current item</returns>
        /// <exception cref="ArgumentNullException">currentItem null or empty</exception>
        string GenerateNextItem(string currentItem);
    }
}
