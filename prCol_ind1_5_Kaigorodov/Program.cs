using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace prCol_ind_5_Kaigorodov
{
    class Program
    {
        static void Main(string[] args)
        {
            process process = new process("text.txt");
            process.Print();
        }
    }
}

