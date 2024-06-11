using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Combo
    {
        private bool _filledWithIr = false;

        public bool FilledWithIr
        {
            get { return _filledWithIr; }
            set
            {
                _filledWithIr = value;
                UpdateTotalDuration();
                UpdateV1tPctg();
                UpdateOutput();
                Skill.UpdateCombo();
            }
        }

        private bool _doesLastUseComboDelay = false;
        public bool DoesLastUseComboDelay
        {
            get { return _doesLastUseComboDelay; }
            set
            {
                _doesLastUseComboDelay = value;
                OutputLastRecovery = value ? "T" : "F";
                OutputLastRecoveryColor = value ? "#0000FF" : "#FF0000";
                UpdateIr();
                UpdateIrPctg();
                UpdateTotalDuration();
                UpdateV1tPctg();
                UpdateOutput();
                Skill.UpdateCombo();
            }
        }

        public int IrCount;
        public double IrDuration;

        public void UpdateIr()
        {
            if (Periodic)
            {
                IrCount = 0;
                OutputIrCount = IrCount.ToString();
                IrDuration = 0.0;
                return;
            }
            if (SkillList.Count == 0)
            {
                IrCount = 1;
                OutputIrCount = IrCount.ToString();
                IrDuration = Skill.IrDelay;
                return;
            }
            double requiredIrDuration = 0.0;
            int idx = -1;
            double cd;
            double currRequiredIrDuration;
            foreach (var skillName in SkillList)
            {
                cd = Skill.OriginCdDict[skillName] * 0.94;
                cd = cd <= 5.0 ? cd : Math.Max(5.0, cd * (1 - 0.05 * _hatSecond));
                currRequiredIrDuration = cd - ComboDuration + Skill.ServerDelay;
                if (Skill.CanComboReduceCdDict[skillName])
                {
                    currRequiredIrDuration -= (SkillList.Count - 1 - Math.Max(0, idx)) * 1000.0;
                }
                requiredIrDuration = Math.Max(requiredIrDuration, currRequiredIrDuration);
                ++idx;
            }
            requiredIrDuration -= (_doesLastUseComboDelay ? 0 : LastSkillRecovery);
            requiredIrDuration = Math.Max(0.0, requiredIrDuration);
            IrCount = (int)Math.Ceiling(requiredIrDuration / Skill.IrDelay);
            OutputIrCount = IrCount.ToString();
            IrDuration = IrCount * Skill.IrDelay;
        }
    }
}
