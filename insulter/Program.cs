using System;
using System.Collections.Generic;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> insults = new List<string>()
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            int randomIndex()
            {
                int index = new Random().Next(0, 6);
                return index;
            }

            List<int> indexes = new List<int>();
            int numCheck = randomIndex();

            while (indexes.Count < 3)
            {
                if (indexes.Contains(numCheck))
                {
                    numCheck = randomIndex();
                }
                else
                {
                    indexes.Add(numCheck);
                }
            }

            for (int i = 0; i < indexes.Count; i++)
            {
                int insultIndex = indexes[i];
                Console.WriteLine(insults[insultIndex]);
            }
        }
    }
}
