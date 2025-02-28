using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MapleWPF
{
    internal partial class Combo
    {
        public double NormalComboPctg;
        public double NormalIrPctg;
        public double NormalE2Pctg;
        public double V1ComboPctg;
        public double V1IrPctg;
        public double V1E2Pctg;
        public double V1V2ComboPctg;
        public double V1V2IrPctg;
        public double V1V2E2Pctg;
        public double V1tPctg;

        public double TotalDuration;
        public double OutputNormalPctg;
        public double OutputV1Pctg;
        public double OutputNormalPctgDensity;
        public double OutputV1PctgDensity;

        public void UpdateTotalDuration()
        {
            if (Periodic)
            {
                TotalDuration = ComboDuration + PauseDuration;
            }
            else {
                TotalDuration = ComboDuration;
                if (!_doesLastUseComboDelay)
                {
                    TotalDuration += LastSkillRecovery;
                }
                if (_filledWithIr)
                {
                    TotalDuration += IrDuration;
                }
            }
            OutputTotalDuration = TotalDuration.ToString();
        }

        public void UpdateAllComboPctg()
        {
            NormalComboPctg = 0.0;
            V1ComboPctg = 0.0;
            V1V2ComboPctg = 0.0;
            foreach (var skillName in SkillList) {
                NormalComboPctg += Skill.NormalCompPctgDict[skillName];
                V1ComboPctg += Skill.V1CompPctgDict[skillName];
                V1V2ComboPctg += Skill.V1V2CompPctgDict[skillName];
            }
        }

        public void UpdateV1AndV1V2ComboPctg()
        {
            V1ComboPctg = 0.0;
            V1V2ComboPctg = 0.0;
            foreach (var skillName in SkillList)
            {
                V1ComboPctg += Skill.V1CompPctgDict[skillName];
                V1V2ComboPctg += Skill.V1V2CompPctgDict[skillName];
            }
        }

        public void UpdateIrPctg()
        {
            NormalIrPctg = Skill.IrNormalCompPctg * IrCount;
            V1IrPctg = Skill.IrV1CompPctg * IrCount;
            V1V2IrPctg = Skill.IrV1V2CompPctg * IrCount;
        }

        public void UpdateV1tPctg()
        {
            if (SkillList.Count == 0)
            {
                V1tPctg = TotalDuration / Skill.V1tCd * Skill.V1tPctg;
            }
            else
            {
                V1tPctg = (TotalDuration + (Periodic ? SkillList.Count : SkillList.Count - 1) * 1000.0) / Skill.V1tCd * Skill.V1tPctg;
            }
        }

        public void UpdateE2Pctg()
        {
            NormalE2Pctg = 0.0;
            V1E2Pctg = 0.0;
            V1V2E2Pctg = 0.0;
            if (SkillList.Contains("we"))
            {
                double weeCd = Skill.CalcCd(12.0, 0.94, _hatSecond);
                double round = Math.Ceiling(weeCd * 1000 / TotalDuration);
                NormalE2Pctg += (Skill.NormalCompPctgDict["wee"] - Skill.NormalCompPctgDict["we"]) / round;
                V1E2Pctg += (Skill.V1CompPctgDict["wee"] - Skill.V1CompPctgDict["we"]) / round;
                V1V2E2Pctg += (Skill.V1V2CompPctgDict["wee"] - Skill.V1V2CompPctgDict["we"]) / round;
            }
            if (SkillList.Contains("sr"))
            {
                double sreCd = Skill.CalcCd(12.0, 0.94, _hatSecond);
                double round = Math.Ceiling(sreCd * 1000 / TotalDuration);
                NormalE2Pctg += (Skill.NormalCompPctgDict["sre"] - Skill.NormalCompPctgDict["sr"]) / round;
                V1E2Pctg += (Skill.V1CompPctgDict["sre"] - Skill.V1CompPctgDict["sr"]) / round;
                V1V2E2Pctg += (Skill.V1V2CompPctgDict["sre"] - Skill.V1V2CompPctgDict["sr"]) / round;
            }
            if (SkillList.Contains("lt"))
            {
                double lteCd = Skill.CalcCd(6.0, 0.94, _hatSecond);
                double round = Math.Ceiling(lteCd * 1000 / TotalDuration);
                NormalE2Pctg += (Skill.NormalCompPctgDict["lte"] - Skill.NormalCompPctgDict["lt"]) / round;
                V1E2Pctg += (Skill.V1CompPctgDict["lte"] - Skill.V1CompPctgDict["lt"]) / round;
                V1V2E2Pctg += (Skill.V1V2CompPctgDict["lte"] - Skill.V1V2CompPctgDict["lt"]) / round;
            }
        }

        public void UpdateOutput()
        {
            OutputNormalPctg = NormalComboPctg + (_filledWithIr ? NormalIrPctg : 0.0) + NormalE2Pctg;
            if (CanBeRiding && Riding)
            {
                OutputNormalPctg *= Skill.V2TotalFinalDmg;
                OutputV1Pctg = (V1V2ComboPctg + (_filledWithIr ? V1V2IrPctg : 0.0)) * Skill.V2TotalFinalDmg + V1V2E2Pctg;
            }
            else
            {
                OutputV1Pctg = V1ComboPctg + (_filledWithIr ? V1IrPctg : 0.0) + V1E2Pctg;
            }
            OutputV1Pctg += V1tPctg;
            if (TotalDuration == 0.0)
            {
                OutputNormalPctgDensity = 0.0;
                OutputV1PctgDensity = 0.0;
            }
            else
            {
                OutputNormalPctgDensity = OutputNormalPctg / TotalDuration;
                OutputV1PctgDensity = OutputV1Pctg / TotalDuration;
            }
            OutputOutputNormal = OutputNormalPctgDensity.ToString("F2");
            OutputOutputV1 = OutputV1PctgDensity.ToString("F2");
        }
    }
}
