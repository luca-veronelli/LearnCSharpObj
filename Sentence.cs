using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpObj
{
    internal class Sentence
    {
        private string[] words;

        public Sentence(string s) 
        {
            words = s.Split(' ');
        }

        // Use indexers to index the class like an array
        // this is a read only indexer, it has no 'set'.
        public string this[int index] => words[index];
    }
}
