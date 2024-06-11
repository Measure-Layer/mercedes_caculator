using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        // 技能延迟
        public static Dictionary<string, double> OriginDelayDict = new Dictionary<string, double>
        {
            { we, 900.0 },
            { sr, 870.0 },
            { lt, 750.0 },
            { ss, 630.0 },
            { gd, 690.0 },
            { us, 810.0 },
            { rr, 540.0 },
            { ab, 660.0 },
            { rm, 840.0 },
            { le, 840.0 }
        };
        public static Dictionary<string, double> OriginComboDelayDict = new Dictionary<string, double>
        {
            { we, 270.0 },
            { sr, 870.0 },
            { lt, 480.0 },
            { ss, 450.0 },
            { gd, 630.0 },
            { us, 600.0 },
            { rr, 300.0 },
            { ab, 660.0 },
            { rm, 840.0 },
            { le, 810.0 }
        };
        public static Dictionary<string, double> DelayDict = new Dictionary<string, double>
        {
            { we, 0.0 },
            { sr, 0.0 },
            { lt, 0.0 },
            { ss, 0.0 },
            { gd, 0.0 },
            { us, 0.0 },
            { rr, 0.0 },
            { ab, 0.0 },
            { rm, 0.0 },
            { le, 0.0 }
        };
        public static Dictionary<string, double> ComboDelayDict = new Dictionary<string, double>
        {
            { we, 0.0 },
            { sr, 0.0 },
            { lt, 0.0 },
            { ss, 0.0 },
            { gd, 0.0 },
            { us, 0.0 },
            { rr, 0.0 },
            { ab, 0.0 },
            { rm, 0.0 },
            { le, 0.0 }
        };

        private static bool _is10;
        public static bool Is10 { 
            get { return _is10; }
            set
            {
                _is10 = value;
                double rate = (_is10 ? 10.0 : 12.0) / 16.0;
                foreach (var pair in OriginDelayDict)
                {
                    DelayDict[pair.Key] = Math.Ceiling(pair.Value * rate / 30.0) * 30.0;
                }
                foreach (var pair in OriginComboDelayDict)
                {
                    ComboDelayDict[pair.Key] = Math.Ceiling(pair.Value * rate / 30.0) * 30.0;
                }
                foreach (var combo in ComboList)
                {
                    combo.UpdateComboDuration();
                    combo.UpdatePeriodic();
                    combo.UpdateIr();
                    combo.UpdateIrPctg();
                    combo.UpdateTotalDuration();
                    combo.UpdateV1tPctg();
                    combo.UpdateOutput();
                    Skill.UpdateCombo();
                }
            }
        }

        public static void InitDelay()
        {
            Is10 = false;
        }
    }
}
