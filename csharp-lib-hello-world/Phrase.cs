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
        public Phrase(){
            phrase = "Hello, World!";
        }
        public string returnPhrase()
        {
            return phrase;
        }
        public void sayPhrase()
        {
            Console.WriteLine(phrase);
        }
        public void setPhrase(string n){
            phrase = n;
        }
    }
}
