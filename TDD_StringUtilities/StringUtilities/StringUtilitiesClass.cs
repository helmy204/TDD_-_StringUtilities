using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtilities
{
    public class StringUtilitiesClass
    {
        public int CountOccurences(string stringToCheck,string stringToFind)
        {
            if(string.IsNullOrEmpty(stringToCheck))
            {
                return -1;
            }

            char[] stringAsCharArray = stringToCheck.ToUpper().ToCharArray();
            char stringToCheckForAsChar = stringToFind.ToUpper().ToCharArray()[0];

            int occurenceCount = 0;

            for(int characterIndex = 0; characterIndex <= stringAsCharArray.GetUpperBound(0); characterIndex++)
            {
                if(stringAsCharArray[characterIndex]==stringToCheckForAsChar)
                {
                    occurenceCount++;
                }
            }

            return occurenceCount;
        }
    }
}
