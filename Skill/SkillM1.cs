using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        // 伊师塔及其烙印
        // 伊师塔
        public static double IrDelay = 120.0;
        public static double IrPctg = 0.0;  // 伊师塔最终倍率
        public static double IrNormalCompPctg = 0.0;
        public static double IrV1CompPctg = 0.0;
        public static double IrV1V2CompPctg = 0.0;
        
        // 烙印
        public static double IrmPctg = 0.0;  // 烙印
        public static double IrmcPctg = 0.0;  // 烙印完成
        public static double IrmePctgPerSkill = 0.0;
        private static double _irExtraFinalDmg;
        public static double IrExtraFinalDmg
        {
            get { return _irExtraFinalDmg; }
            set
            {
                _irExtraFinalDmg = value;
                UpdateIrPctg();
                UpdateIrNormalCompPctg();
                UpdateIrV1CompPctg();
                UpdateIrV1V2CompPctg();
                foreach (var combo in ComboList)
                {
                    combo.UpdateIrPctg();
                    combo.UpdateOutput();
                }
                Skill.UpdateCombo();
            }
        }


        private static int _m1Level = 1;
        public static int M1Level
        {
            get { return _m1Level; }
            set
            {
                _m1Level = value;
                UpdateIrPctg();
                UpdateIrmPctg();
                UpdateIrmcPctg();
                UpdateIrmePctgPerSkill();
                UpdateIrNormalCompPctg();
                UpdateIrV1CompPctg();
                UpdateIrV1V2CompPctg();
                UpdateAllCompPctgDict();
                foreach (var combo in ComboList)
                {
                    combo.UpdateIrPctg();
                    combo.UpdateAllComboPctg();
                    combo.UpdateOutput();
                }
                Skill.UpdateCombo();
            }
        }
        public static void UpdateIrPctg()
        {
            IrPctg = (345 + 6 * _m1Level) * 2 * 2.2 * (1 + IrExtraFinalDmg);
        }
        public static void UpdateIrmPctg()
        {
            IrmPctg = (400 + 7 * _m1Level) * 3;
        }
        public static void UpdateIrmcPctg()
        {
            IrmcPctg = (500 + 8 * _m1Level) * 8;
        }
        public static void UpdateIrmePctgPerSkill()
        {
            IrmePctgPerSkill = (4 * IrmPctg + IrmcPctg) / 30;
        }

        public static void UpdateIrNormalCompPctg()
        {
            IrNormalCompPctg = IrPctg + FaePctgPerSkill + IrmePctgPerSkill / 2;
        }
        public static void UpdateIrV1CompPctg()
        {
            IrV1CompPctg = IrPctg * (1 + V1sIrCount * V1sFinalDmg) + (1 + V1sIrCount) * (FaePctgPerSkill + IrmePctgPerSkill / 2);
        }
        public static void UpdateIrV1V2CompPctg()
        {
            IrV1V2CompPctg = IrPctg * (1 + V1sIrCount * V1sFinalDmg) + FaePctgPerSkill + IrmePctgPerSkill / 2;
        }


        public static void InitM1()
        {
            M1Level = 1;
        }
    }
}
