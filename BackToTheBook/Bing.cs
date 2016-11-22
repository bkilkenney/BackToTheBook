using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Bing : SearchEngine
    {
        public override string[] Search(string findThis)
        {
            return new string[]
            {
                "I found this for you.",                
                "Here are your top matches"
            };

        }
    }
}
