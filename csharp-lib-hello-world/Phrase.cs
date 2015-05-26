// our Phrase class
// sets and gets string phrases
using System;

namespace csharp_lib_hello_world
{
    public class Phrase
    {
        private string phrase;
        // default constructor
        public Phrase()
        {
            phrase = "Hello, World!";
        }

        // overloaded constructor
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
