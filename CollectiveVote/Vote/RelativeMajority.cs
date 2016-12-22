using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectiveVote.Vote
{
    class RelativeMajority
    {
        private string result = "";
        public string Majority(int Greece, int Egypt, int Crimea)
        {
            int g, c, e;
            g = Greece;
            e = Egypt;
            c = Crimea;

            if (g > e && g > c)
            {
                result = "Греция";
            }
            else
            {
                if (e > g && e > c)
                {
                    result = "Египет";
                }
                else
                {
                    if (c > e && c > g)
                    {
                        result = "Крым";
                    }
                    else
                    {
                        e = 0;
                        c = 0;
                        g = 0;
                        return "Проголосуйте заново!";
                    }
                }
            }
            string res = "Ваше место отдыха - " + result;
            result = "";
            return res;
        }
    }
}
