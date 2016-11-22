using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToTheBook
{
    class Google : SearchEngine
    {
        public override string[] Search(string findThis)
        {
            return new string[]
            {
                "Here are some results",
                "Isn't it a relief when I, google, find you all these results?",
                "I found 1.2 Billion results, but you will only look at the first 3"
            };

        }
    }
}
