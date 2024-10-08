﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        public static double ServerDelay = 150.0;
        public static double LongestPause = 210.0;
        public static Dictionary<string, double> OriginCdDict = new Dictionary<string, double>
        {
            { we, 8000.0 },
            { sr, 5000.0 },
            { lt, 0.0 },
            { ss, 0.0 },
            { gd, 0.0 },
            { us, 9000.0 },
            { rr, 0.0 },
            { ab, 0.0 },
            { rm, 4000.0 },
            { le, 0.0 }
        };
        public static Dictionary<string, bool> CanComboReduceCdDict = new Dictionary<string, bool>
        {
            { we, true },
            { sr, true },
            { lt, false },
            { ss, false },
            { gd, false },
            { us, true },
            { rr, false },
            { ab, false },
            { rm, false },
            { le, false }
        };

        public static double CalcCd(double cd, double cdRate, double hatSecond)
        {
            cd *= cdRate;
            if (cd >= 10)
            {
                if (hatSecond >= cd - 10)
                {
                    hatSecond -= cd - 10;
                    cd = 10;
                }
                else
                {
                    cd -= hatSecond;
                    hatSecond = 0;
                }
            }
            if (cd >= 5 && hatSecond >= 0)
            {
                cd = cd * (1 - hatSecond * 0.05);
                cd = cd >= 5 ? cd : 5;
            }
            return cd;
        }
    }
}
