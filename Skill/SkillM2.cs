using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        private static int _m2Level = 30;
        public static int M2Level
        {
            get { return _m2Level; }
            set
            {
                _m2Level = value;
                UpdateIrmPctg();
                UpdateIrmcPctg();
                UpdateIrmePctgPerSkill();
                UpdateIrNormalCompPctg();
                UpdateIrV1CompPctg();
                UpdateIrV1V2CompPctg();
                UpdateWePctg();
                UpdateSrPctg();
                UpdateLtPctg();
                UpdateAllCompPctg(we);
                UpdateAllCompPctg(sr);
                UpdateAllCompPctg(lt);
                UpdateAllCompPctg("wee");
                UpdateAllCompPctg("sre");
                UpdateAllCompPctg("lte");
                foreach (var combo in ComboList)
                {
                    combo.UpdateIrPctg();
                    combo.UpdateAllComboPctg();
                    combo.UpdateE2Pctg();
                    combo.UpdateOutput();
                }
                Skill.UpdateCombo();
            }
        }
        public static void UpdateWePctg()
        {
            PctgDict[we] = (550 + 10 * _m2Level) * 10 * 2.2;
            PctgDict["wee"] = (605 + 11 * _m2Level) * 10 * 2.2;
        }
        public static void UpdateSrPctg()
        {
            PctgDict[sr] = (695 + 12 * _m2Level) * 4 * 2.2;
            PctgDict["sre"] = (740 + 14 * _m2Level) * 4 * 2.2;
        }
        public static void UpdateLtPctg()
        {
            PctgDict[lt] = (510 + 9 * _m2Level) * 4 * 2.2;
            PctgDict["lte"] = (590 + 9 * _m2Level) * 4 * 2.2;
        }

        public static void InitM2()
        {
            M2Level = 30;
        }
    }
}
