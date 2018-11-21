using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallows_OIS12
{
    class Word
    {
        string word;

        public Word(string word)
        {
            this.word = word;
        }

        public int getCharIndex(char guessedChar)
        {
            if (this.word.Contains(guessedChar))
            {
                if (this.word[0] == guessedChar)
                {
                    return 0;
                }
                if (this.word[1] == guessedChar)
                {
                    return 1;
                }
                if (this.word[2] == guessedChar)
                {
                    return 2;
                }
                if (this.word[3] == guessedChar)
                {
                    return 3;
                }
                if (this.word[4] == guessedChar)
                {
                    return 4;
                }
                if (this.word[5] == guessedChar)
                {
                    return 5;
                }
                if (this.word[6] == guessedChar)
                {
                    return 6;
                }
            }
            return -1;
        }

        public override string ToString()
        {
            return word;
        }
    }
}
