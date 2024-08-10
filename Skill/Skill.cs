using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace MapleWPF
{
    internal partial class Skill
    {
        public static string ir = "ir";  // 伊师塔
        public static string we = "we";  // 艾琳
        public static string sr = "sr";  // 传说
        public static string lt = "lt";  // 飞叶
        public static string ss = "ss";  // 双杀
        public static string gd = "gd";  // 俯冲
        public static string us = "us";  // 独角兽
        public static string rr = "rr";  // 冲锋拳
        public static string ab = "ab";  // 飞腿
        public static string rm = "rm";  // 月瀑
        public static string le = "le";  // 闪电

        public static List<string> SkillNameList = new List<string> { we, sr, lt, ss, gd, us, rr, ab, rm, le };


        public static string m1 = "m1";  // 精通1
        public static string m2 = "m2";  // 精通2
        public static string e1 = "e1";  // 精灵元素强化
        public static string e2 = "e2";  // 希比迪亚强化

        public static Dictionary<string, HashSet<string>> NextSkillListDict = new Dictionary<string, HashSet<string>>
        {
            { we, new HashSet<string> { "sr", "us", "ss", "rr", "le" } },
            { sr, new HashSet<string> { "we", "lt", "gd", "rm" } },
            { lt, new HashSet<string> { "we", "sr", "gd" } },
            { ss, new HashSet<string> { "we", "sr", "us", "rr", "le" } },
            { gd, new HashSet<string> { "we", "sr", "lt", "ss", "us", "rr", "le" } },
            { us, new HashSet<string> { "we", "sr", "ss", "rr", "le" } },
            { rr, new HashSet<string> { "ab", "rm" } },
            { ab, new HashSet<string> { "we", "sr", "lt", "gd", "rm" } },
            { rm, new HashSet<string> { "we", "sr", "lt", "gd" } },
            { le, new HashSet<string> { "we", "sr", "ss", "us", "rr" } }
        };

        
        public static ObservableCollection<Combo> ComboList = new ObservableCollection<Combo>();

        public static void AddCombo(List<string> skillList)
        {
            Combo combo = new Combo(skillList);
            ComboList.Add(combo);
            UpdateCombo();
        }

        public static void RemoveCombo(Combo combo)
        {
            ComboList.Remove(combo);
            UpdateCombo();
        }

        public static void LoadDefaultCombo()
        {
            ComboList.Clear();
            ComboList.Add(new Combo(new List<string> { we, ss, us, ss, sr, lt, gd }));
            ComboList.Add(new Combo(new List<string> { we, ss, us, ss, rr, ab, lt }));
            ComboList.Add(new Combo(new List<string> { we, ss }));
            ComboList.Add(new Combo(new List<string> { we, ss, us, ss, sr, lt}));
            ComboList.Add(new Combo(new List<string> { we, us, ss, rr, ab, lt}));
            ComboList.Add(new Combo(new List<string> { we, ss }));
            ComboList.Add(new Combo(new List<string> { we, us, ss, sr, lt }));
            ComboList.Add(new Combo(new List<string> { we, ss }));
            ComboList.Add(new Combo(new List<string> { we, us, sr, lt }));
            ComboList.Add(new Combo(new List<string> { we, ss }));
            ComboList[3].HatSecond = 1;
            ComboList[4].HatSecond = 1;
            ComboList[5].HatSecond = 1;
            ComboList[6].HatSecond = 4;
            ComboList[7].HatSecond = 4;
            ComboList[8].HatSecond = 7;
            ComboList[9].HatSecond = 7;
            ComboList[3].HatSecondStr = "1";
            ComboList[4].HatSecondStr = "1";
            ComboList[5].HatSecondStr = "1";
            ComboList[6].HatSecondStr = "4";
            ComboList[7].HatSecondStr = "4";
            ComboList[8].HatSecondStr = "7";
            ComboList[9].HatSecondStr = "7";
            UpdateCombo();
        }

        public static void UpdateCombo()
        {
            int i = 1;
            foreach (var combo in ComboList)
            {
                combo.Order = i.ToString();
                ++i;
            }
            if (ComboList.Count > 0)
            {
                double normalStd = 0.0;
                double v1Std = 0.0;
                foreach (var combo in ComboList)
                {
                    normalStd = combo.OutputNormalPctgDensity;
                    v1Std = combo.OutputV1PctgDensity;
                    if (normalStd > 0.0)
                    {
                        break;
                    }
                }
                if (normalStd == 0.0)
                {
                    foreach (var combo in ComboList)
                    {
                        combo.OutputNormalRate = 0.0.ToString("F2") + "%";
                        combo.OutputV1Rate = 0.0.ToString("F2") + "%";
                    }
                }
                else
                {
                    double normalRate, v1Rate;
                    foreach (var combo in ComboList)
                    {
                        normalRate = combo.OutputNormalPctgDensity / normalStd * 100.0;
                        v1Rate = combo.OutputV1PctgDensity / v1Std * 100.0;
                        combo.OutputNormalRate = normalRate.ToString("F2") + "%";
                        combo.OutputV1Rate = v1Rate.ToString("F2") + "%";
                    }
                }
            }
        }

        static Skill()
        {
            InitDelay();
            InitM1();
            InitM2();
            InitE1();
            InitE2();
        }
    }
}
