using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sjerrul.ConwaysRow
{
    public static class StringSplitter
    {
        public static IList<string> Split(string input)
        {
            IList<string> retval = new List<string>();

            int index = IndexOfFirstCharacterChange(input);
            if (index < input.Length)
            {
                IList<string> t = StringSplitter.Split(input.Substring(index));
                retval = retval.Concat(t).ToList();
            }
                
            retval.Insert(0, input.Substring(0, index));
            
            return retval;
        }

        private static int IndexOfFirstCharacterChange(string input)
        {
            if (String.IsNullOrWhiteSpace(input))
            {
                return 0;
            }

            if (input.Length == 1)
            {
                return 1;
            }

            int index = 0;
            char current = input[index];
            index++;
            char next = input[index];

            while (current == next)
            {
                index++;
                if (index >= input.Length)
                {
                    break;
                }

                current = next;
                next = input[index];
            }

            return index;
        }
    }
}
