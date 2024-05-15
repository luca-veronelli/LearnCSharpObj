using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharpObj
{
    internal class Skill
    {
        /* SKILL 1
        
        private string _name;
        private string _rating;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; }
        }

        public string Rating
        {
            get { return _rating; }
            set { _rating = value; }
        }

        */

        /* SKILL 2
        
        // You can set an auto implemented property IF 
        // you don't need to add other logic to the property
        // other than 'get' and 'set'.
        public string Name { get; set; }

        // Initiate auto implemented properties like this:
        public sbyte Rating { get; set; } = 1
        */
    }
}
