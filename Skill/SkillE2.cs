using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        public static Dictionary<string, bool> CanRiderUseDict = new Dictionary<string, bool>
        {
            { we, true },
            { sr, true },
            { lt, false },
            { ss, false },
            { gd, true },
            { us, true },
            { rr, false },
            { ab, false },
            { rm, false },
            { le, false }
        };

        private static double _v2ExtraFinalDmgFromAttPctg;
        public static double V2ExtraFinalDmgFromAttPctg
        {
            get { return _v2ExtraFinalDmgFromAttPctg; }
            set
            {
                _v2ExtraFinalDmgFromAttPctg = value;
                UpdateV2TotalFinalDmg();
            }
        }

        public static double V2ExtraFinalDmg = 0.0;
        public static double V2TotalFinalDmg = 0.0;


        private static int _e2Level = 30;
        public static int E2Level
        {
            get { return _e2Level; }
            set
            {
                _e2Level = value;
                UpdateV2ExtraFinalDmg();
                UpdateV2TotalFinalDmg();
                foreach (var combo in ComboList)
                {
                    combo.UpdateOutput();
                }
                Skill.UpdateCombo();
            }
        }

        public static void UpdateV2ExtraFinalDmg()
        {
            V2ExtraFinalDmg = (_e2Level + 5) / 6 * 0.01;
        }

        public static void UpdateV2TotalFinalDmg()
        {
            V2TotalFinalDmg = (1.0 + V2ExtraFinalDmg) * (1.0 + V2ExtraFinalDmgFromAttPctg);
        }
        public static void InitE2()
        {
            E2Level = 30;
            V2ExtraFinalDmgFromAttPctg = 0.0;
        }
    }
}
