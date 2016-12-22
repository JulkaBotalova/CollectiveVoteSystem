using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveVote.Vote
{
    public class Borde
    {
        string result;

        int g, c, e = 0;
        public string MethodBorde(int q, int[] Greece, int[] Egypt, int[] Crimea)
        {

            g = Summ(Greece, q);
            c = Summ(Crimea,q);
            e = Summ(Egypt, q);

            if(g > c && g > e)
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

        public int Summ(int[] evaluation, int q)
        {
            int res = 0;
            int[] ar = new int[3];

            for (int i = 0; i < q; i++)
            {
                if (evaluation[i] == 1)
                {
                    ar[0] = ar[0] + 1;
                }

                if (evaluation[i] == 2)
                {
                    ar[1] = ar[1] + 1;
                }

                if (evaluation[i] == 3)
                {
                    ar[2] = ar[2] + 1;
                }
            }
            for (int i = 0; i <= 2; i++)
            {
                res = res + ar[i] * (2 - i);
            }
            return res;
        }
    }
}
