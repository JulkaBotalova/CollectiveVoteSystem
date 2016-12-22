using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveVote.Vote.Condorcet
{
    class Kopland
    {
        string result;
        int g, c, e = 0;

        public string MethodKopland(int quantity, int[] Greece, int[] Egypt, int[] Crimea)
        {
            e = CountOfVotes(Egypt, Crimea, quantity) + CountOfVotes(Egypt, Greece, quantity);
            g = CountOfVotes(Greece, Egypt, quantity) + CountOfVotes(Greece, Crimea, quantity);
            c = CountOfVotes(Crimea, Egypt, quantity) + CountOfVotes(Crimea, Greece, quantity);

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


        int resultAB, res = 0;
        public int CountOfVotes(int[] CountryA, int[] CountryB, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                int inc = CountryA[i] < CountryB[i] ? 1 : -1;
                res += inc;
            }

            resultAB = res;
            res = 0;
            return resultAB;
        }



    }
}
