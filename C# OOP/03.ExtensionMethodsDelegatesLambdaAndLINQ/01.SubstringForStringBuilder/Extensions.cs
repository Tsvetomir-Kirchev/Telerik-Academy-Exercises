using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SubstringForStringBuilder
{
    public static class Extensions
    {
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            if (index < 0 || index > sb.Length
                || length > sb.Length || index + length > sb.Length)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = index; i < length; i++)
            {
                result.Append(sb[i]);
            }
            return result;
        }
    }
}
