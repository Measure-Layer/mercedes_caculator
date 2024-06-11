using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Combo
    {
        public double OriginComboCd = 0.0;
        public double OriginNotComboCd = 0.0;

        public double ComboCd = 0.0;
        public double NotComboCd = 0.0;

        private int _hatSecond = 0;
        public int HatSecond
        {
            get { return _hatSecond; }
            set 
            { 
                _hatSecond = value;
                UpdateCd();
                UpdatePeriodic();
                UpdateIr();
                UpdateIrPctg();
                UpdateTotalDuration();
                UpdateV1tPctg();
                UpdateOutput();
                Skill.UpdateCombo();
            }
        }

        public void UpdateOriginCd()
        {
            OriginComboCd = 0.0;
            OriginNotComboCd = 0.0;
            double originCd;
            foreach (var skillName in SkillList)
            {
                originCd = Skill.OriginCdDict[skillName];
                if (Skill.CanComboReduceCdDict[skillName])
                {
                    OriginComboCd = Math.Max(OriginComboCd, originCd);
                }
                else
                {
                    OriginNotComboCd = Math.Max(OriginNotComboCd, originCd);
                }
            }
            OriginComboCd *= 0.94;
            OriginNotComboCd *= 0.94;
        }

        public void UpdateCd()
        {
            double rate = 1 - 0.05 * _hatSecond;
            if (OriginComboCd > 5.0)
            {
                ComboCd = Math.Max(5.0, OriginComboCd * rate);
            }
            if (OriginNotComboCd > 5.0)
            {
                NotComboCd = Math.Max(5.0, OriginNotComboCd * rate);
            }
        }
    }
}
