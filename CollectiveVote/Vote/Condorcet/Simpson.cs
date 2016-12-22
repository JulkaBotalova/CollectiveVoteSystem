using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveVote.Vote.Condorcet
{
    class Simpson
    {
        string result;
        int g, c, e, gc, ge, eg, ec, ce, cg = 0;
        public string MethodSimpson(int quantity, int[] Greece, int[] Egypt, int[] Crimea)
        {           
            gc = CountOfVotes(Greece, Crimea, quantity);
            ge = CountOfVotes(Greece, Egypt, quantity);
            eg = CountOfVotes(Egypt, Greece, quantity);
            ec = CountOfVotes(Egypt, Crimea, quantity);
            ce = CountOfVotes(Crimea, Egypt, quantity);
            cg = CountOfVotes(Crimea, Greece, quantity);

            g = MoreLess(ge, gc);
            c = MoreLess(ce, cg);
            e = MoreLess(ec, eg);


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

        int resultML;
        private int MoreLess(int M, int L)
        {
            if (M > L)
            {
                resultML = L;
            }
            else
            {
                resultML = M;
            }
            return resultML;
        }
    }
}
