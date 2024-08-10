using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        public static Dictionary<string, double> PctgDict = new Dictionary<string, double>
        {
            { we, 11330.0 },
            { sr, 5632.0 },
            { lt, 4136.0 },
            { ss, 4012.8 },
            { gd, 4576.0 },
            { us, 7509.6 }, 
            { rr, 2406.8 },
            { ab, 3986.4 },
            { rm, 4791.6 },
            { le, 2805.0 },
            { "wee", 0.0 },
            { "sre", 0.0 },
            { "lte", 0.0 }
        };

        public static Dictionary<string, double> NormalCompPctgDict = new Dictionary<string, double> 
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
            { le, 0.0 },
            { "wee", 0.0 },
            { "sre", 0.0 },
            { "lte", 0.0 }
        };

        public static void UpdateNormalCompPctg(string skillName)
        {
            NormalCompPctgDict[skillName] = PctgDict[skillName] + FaePctgPerSkill + IrmePctgPerSkill;
        }
        public static void UpdateV1CompPctg(string skillName)
        {
            V1CompPctgDict[skillName] = PctgDict[skillName] * (1 + V1sCount * V1sFinalDmg) + (1 + V1sCount) * (FaePctgPerSkill + IrmePctgPerSkill);
        }
        public static void UpdateV1V2CompPctg(string skillName)
        {
            V1V2CompPctgDict[skillName] = PctgDict[skillName] * (1 + V1sCount * V1sFinalDmg) + FaePctgPerSkill + IrmePctgPerSkill;
        }
        public static void UpdateAllCompPctg(string skillName)
        {
            UpdateNormalCompPctg(skillName);
            UpdateV1CompPctg(skillName);
            UpdateV1V2CompPctg(skillName);
        }
        public static void UpdateV1AndV1V2CompPctgDict()
        {
            foreach (var skillName in SkillNameList)
            {
                UpdateV1CompPctg(skillName);
                UpdateV1V2CompPctg(skillName);
            }
        }
        public static void UpdateAllCompPctgDict()
        {
            foreach (var skillName in SkillNameList)
            {
                UpdateAllCompPctg(skillName);
            }
        }
        public static Dictionary<string, double> V1CompPctgDict = new Dictionary<string, double>
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
            { le, 0.0 },
            { "wee", 0.0 },
            { "sre", 0.0 },
            { "lte", 0.0 }
        };
        // 未考虑V2提供的终伤
        public static Dictionary<string, double> V1V2CompPctgDict = new Dictionary<string, double>
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
            { le, 0.0 },
            { "wee", 0.0 },
            { "sre", 0.0 },
            { "lte", 0.0 }
        };
    }
}
