using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WareHouseToAquaticOrganisms
{
   public static class Validator
    {
        //private static Regex weightPattern = new Regex("\\b\\d{1,}\\b");
        private static Regex namePattern = new Regex("\\b[a-zA-Z]+\\b");
        private static Regex egnPattern = new Regex("\\b[4-9]{1}\\d{1,9}\\b");
       
        /// <summary>
        /// Validate name strings
        /// </summary>
        /// <param name="aName"></param>
        /// <returns></returns>
        public static bool isValidName(string aName) {
            return namePattern.IsMatch(aName);
        }

        public static bool isValidEGN(string EGN) {
            return egnPattern.IsMatch(EGN);
        }
        /// <summary>
        /// Validate string by pattern. The string must containe only digits.
        /// </summary>
        /// <param name="aName"></param>
        /// <returns></returns>
        //public static bool isValidWeight( string aName )
        //{
        //    return weightPattern.IsMatch(aName);
        //}

    }
}
