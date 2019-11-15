using System;
using System.Collections.Generic;

namespace DictionaryOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create a dictionary with key value pairs to represent words (key) and its definition (value)
             */
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

            // Add several more words and their definitions
            wordsAndDefinitions.Add("Do", "A deer, a female deer");
            wordsAndDefinitions.Add("Re", "a drop of golden sun");
            wordsAndDefinitions.Add("Mi", "A name I call myself");
            wordsAndDefinitions.Add("Fa", "A long long way to run");
            wordsAndDefinitions.Add("Sol", "A needle pulling thread");
            wordsAndDefinitions.Add("La", "A note to follow Sol");
            wordsAndDefinitions.Add("Ti", "A drink with jam and bread");

            /*
                Use square brackets to get the definition of two of the
                words and then output them to the console
            */
            Console.WriteLine(wordsAndDefinitions["Do"]);
            Console.WriteLine(wordsAndDefinitions["Ti"]);

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($"The definition of {word.Key} is {word.Value}");
            };
            /*
                Below, loop over the wordsAndDefinitions dictionary to get the following output:
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
                    The definition of (WORD) is (DEFINITION)
            */
            foreach (KeyValuePair<string, string> word in wordsAndDefinitions) { }
        }
    }
}