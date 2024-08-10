using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        public static double V1tCd = 10000.0;
        public static double V1tPctg = 7200.0;
        public static double V1sCount = 1.845;
        public static double V1sIrCount = 0.646875;

        public static double V1sFinalDmg = 0.6;

        private static int _e1Level = 30;
        public static int E1Level
        {
            get { return _e1Level; }
            set
            {
                _e1Level = value;
                UpdateV1tPctg();
                UpdateV1sFinalDmg();
                UpdateIrV1CompPctg();
                UpdateIrV1V2CompPctg();
                UpdateV1AndV1V2CompPctgDict();
                foreach (var combo in ComboList)
                {
                    combo.UpdateV1tPctg();
                    combo.UpdateV1AndV1V2ComboPctg();
                    combo.UpdateIrPctg();
                    combo.UpdateE2Pctg();
                    combo.UpdateOutput();
                    Skill.UpdateCombo();
                }
            }
        }
        public static void UpdateV1tPctg()
        {
            double rate = 1.1 + 0.01 * _e1Level + (_e1Level >= 10 ? 0.05 : 0) + (_e1Level >= 20 ? 0.05 : 0) + (_e1Level >= 30 ? 0.1 : 0);
            V1tPctg = 7200.0 * rate;
        }
        public static void UpdateV1sFinalDmg()
        {
            V1sFinalDmg = ((_e1Level + 1) >> 1) * 0.01 + 0.6;
        }

        public static void InitE1()
        {
            E1Level = 30;
        }
    }
}
