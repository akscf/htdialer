using HTDialer.Models.Configurations;
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
        private char[] cutChars;
        private Regex regx;

        public void Configure(Configuration configuration)
        {
            if (configuration == null)
            {
                regx = null;
                cutChars = null;
                return;
            }
            // 
            regx = String.IsNullOrEmpty(configuration.Regex) ? null : new Regex(configuration.Regex);
            cutChars = String.IsNullOrEmpty(configuration.CutChars) ? null : configuration.CutChars.ToCharArray();
        }

        public string Clear(string destinationNumber)
        {
            if (String.IsNullOrEmpty(destinationNumber))
            {
                return destinationNumber;
            }
            //
            if (cutChars == null)
            {
                return destinationNumber.Replace(" ", "");
            }
            //
            string s = destinationNumber;
            foreach (char e in cutChars)
            {
                s = s.Replace(e, ' ');
            }
            //
            return s.Replace(" ", "");
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
