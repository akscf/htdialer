using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/**
 *
 * @author AlexandrinKS <aks@cforge.org>
 */
namespace HTDialer.Utils
{
    class DestinationValidator
    {
        private Regex regx;

        public void ApplyRegex(string pattern)
        {
            if (!String.IsNullOrEmpty(pattern))
            {
                regx = new Regex(pattern);
            }
            else
            {
                regx = null;
            }            
        }

        public string Format(string destinationNumber)
        {
            if (String.IsNullOrEmpty(destinationNumber))
            {
                return destinationNumber;
            }
            return destinationNumber.Replace(" ", "").Replace("+", "").Replace("-", "").Replace("(", "").Replace(")", "");
        }

        public bool IsValid(string destinationNumber)
        {
            if (regx == null)
            {
                return true;
            }
            return regx.IsMatch(destinationNumber);
        }

    }
}
