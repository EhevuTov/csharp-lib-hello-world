using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lib_hello_world
{
    public class Phrase
    {
        private string phrase;
        public Phrase()
        {
            phrase = "Hello, World!";
        }

        public Phrase(string str)
        {
            set(str);
        }

        public string get()
        {
            return phrase;
        }

        public void set(string n)
        {
            phrase = n;
        }

        public void say()
        {
            Console.WriteLine(phrase);
        }
    }
}
