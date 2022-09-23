using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace NewYearGift
{
    /// <summary>
    /// Starts the App.
    /// </summary>
    public static class Extentions
    {
        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="sweet">console call params.</param>
        /// <returns> string. </returns>
        public static string GetWeightAsString(this Sweet sweet)
        {
            if (sweet is null)
            {
                throw new ArgumentNullException(nameof(sweet));
            }

            return sweet.Weight.ToString();
        }

        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="name">console call params.</param>
        /// <returns> bool. </returns>
        public static bool IsThisNuts(this string name)
        {
            return name == "Nuts";
        }

        /// <summary>
        /// Starts the App.
        /// </summary>
        /// <param name="sweet">console call params.</param>
        public static void WriteSweet(this Sweet sweet)
        {
            Console.WriteLine($"Name: {sweet.Name}, weight: {sweet.Weight}.");
        }
    }
}
