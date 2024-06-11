using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Combo
    {
        public double NormalComboPctg;
        public double NormalIrPctg;
        public double V1ComboPctg;
        public double V1IrPctg;
        public double V1V2ComboPctg;
        public double V1V2IrPctg;
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

        public void UpdateOutput()
        {
            OutputNormalPctg = NormalComboPctg + (_filledWithIr ? NormalIrPctg : 0.0);
            if (CanBeRiding && Riding)
            {
                OutputNormalPctg *= Skill.V2TotalFinalDmg;
                OutputV1Pctg = (V1V2ComboPctg + (_filledWithIr ? V1V2IrPctg : 0.0)) * Skill.V2TotalFinalDmg;
            }
            else
            {
                OutputV1Pctg = V1ComboPctg + (_filledWithIr ? V1IrPctg : 0.0);
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
