using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveVote.Vote.Condorcet
{
    class Winner
    {
        string result;
        int g, c, e, rc = 0;

        public string Win(int quantity, int[] Greece, int[] Egypt, int[] Crimea)
        {
            g = CountOfVotes(Greece, Egypt, quantity) + CountOfVotes(Greece, Crimea, quantity);
            e = CountOfVotes(Egypt, Crimea, quantity) + CountOfVotes(Egypt, Greece, quantity);
            c = CountOfVotes(Crimea, Greece, quantity) + CountOfVotes(Crimea, Egypt, quantity);

            if (g > c && g > e)
            {
                result = "Греция";
            }
            else
            {
                if (e > c && e > g)
                {
                    result = "Египет";
                }
                else
                {
                    if (c > g && c > e)
                    {
                        result = "Крым";
                    }
                    else
                    {
                        result = "Переголосуйте!";
                    }
                }
            }
            return result;
        }

        int resultAB, resAB;
        private int CountOfVotes(int[] CountryA, int[] CountryB, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                if (CountryA[i] < CountryB[i])
                {
                    resAB = resAB + 1;
                }
            }
            resultAB = resAB;
            resAB = 0;
            return resultAB;
        }
    }
}
