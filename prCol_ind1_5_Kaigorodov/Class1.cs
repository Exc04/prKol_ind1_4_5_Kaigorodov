using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prCol_ind_5_Kaigorodov
{
    public class process
    {
        private string _file;

        public process(string file)
        {
            _file = file;
        }

        public List<string> Getword()
        {
            string content = File.ReadAllText(_file);

            var words = content.Split(new char[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}' }, StringSplitOptions.RemoveEmptyEntries);

            var upper = words.Where(w => w.Length > 0 && char.IsUpper(w[0]));
            var lower = words.Where(w => w.Length > 0 && char.IsLower(w[0]));

            return upper.Concat(lower).ToList();
        }

        public void Print()
        {
            foreach (string word in Getword())
            {
                Console.WriteLine(word);
            }
        }
    }
}
