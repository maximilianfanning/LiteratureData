using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiteratureWorkDataCounter
{
    class StatFinder
    {
        public string originalWork;
        public StatFinder(string input)
        {
            originalWork = input;
        }
        public static int letterCount()
        {
            throw new InvalidOperationException();
        }
        public int[] characterCount()
        {
            int[] characterCounter = new int[129];
            for (int i = 0; i < originalWork.Length; i++)
            {
                int placeHolder = originalWork[i];
                characterCounter[placeHolder]++;
                characterCounter[128]++;
            }
            return characterCounter;
        }
        public int letterCount(int[] characterCount)
        {
            int output = 0;
            for (int i = 0; i < 129; i++)
            {
                char convertedCharacter = (char)i;
                if (char.IsLetter(convertedCharacter))
                {
                    output += characterCount[i];
                }
            }
            return output;
        }
        public static int arrayAdd(int[] input)
        {
            int output = 0;
            for (int i = 0; i < input.Length; i++)
            {
                output += input[i];
            }
            return output;
        }
    }
}
