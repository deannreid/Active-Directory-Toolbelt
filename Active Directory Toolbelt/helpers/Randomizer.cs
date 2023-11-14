using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Active Directory Toolbelt 
 * Developed by @ Dean Reid
 *
 * Class Name: Randomizer
 *
 * Class Information:
 *
 * Class handles Static helper class providing tools for generating random numbers or strings.
 *
 * Program Version: 1.0
 * Code Version: 1.0
 *
 * Updates:
 * 14/11/2023 - Initial Code Development
 *
 */
namespace Active_Directory_Toolbelt.helpers
{
    public static class Randomizer
    {

        /// Provides Random Number Generation
        private static readonly Random rndNBR = new Random();

        /// Generates a random integer between the specified min and max values
        private static readonly char[] AllowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

        #region GenerateNumber
        // Return a random number within a specified range.
        public static int GenerateNumber(int min, int max)
        {
            return rndNBR.Next(min, max);
        }
        
        //return a nonnegative random number less than the specified maximum
        public static int GenerateNumber(int max)
        {
            return rndNBR.Next(max);
        }

        //return a nonnegative random number
        public static int GenerateNumber()
        {
            return rndNBR.Next();
        }
        #endregion

        #region GenerateString
        //return a random string where its size is within a specified range
        public static string GenerateString(int min, int max)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (var i = 0; i < builder.Capacity; i++)
            {
                ch = AllowedChars[GenerateNumber(AllowedChars.Length)];
                builder.Append(ch);
            }

            return builder.ToString();
        }
        #endregion

        #region GenerateGuid
        // Initializes a new instance of the <see cref="Guid"/> structure.
        public static Guid GenerateGuid()
        {
            return Guid.NewGuid();
        }
        #endregion
    }
}
