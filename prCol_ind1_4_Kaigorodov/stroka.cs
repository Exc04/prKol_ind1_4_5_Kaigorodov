using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prCol_ind_4_Kaigorodov
{
    public class stroka
    {
        public static bool Revers(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            Stack<char> stack = new Stack<char>(s1);

            return s2.All(c => stack.Count > 0 && stack.Pop() == c);
        }
    }
}
