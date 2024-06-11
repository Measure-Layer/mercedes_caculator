using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Combo
    {
		public bool Periodic;
		public double ComboDuration;
		public double LastSkillRecovery;
		public double PauseDuration;

		public void UpdateComboDuration()
		{
			ComboDuration = 0.0;
			foreach (var skillName in SkillList)
			{
				ComboDuration += Skill.ComboDelayDict[skillName];
			}
			if (SkillList.Count == 0)
			{
				LastSkillRecovery = 0.0;
				return;
			}
			string LastSkill = SkillList.Last();
			LastSkillRecovery = Skill.DelayDict[LastSkill] - Skill.ComboDelayDict[LastSkill];
		}

		public void UpdatePeriodic()
		{
			if (SkillList.Count == 0)
			{
				Periodic = false;
				OutputPeriodic = "F";
				OutputPeriodicColor = "#FF0000";
				PauseDuration = 0.0;
				OutputPauseDuration = Math.Round(PauseDuration).ToString();
				return;
			}
			Periodic = true;
			double requiredComboCd = ComboDuration + SkillList.Count * 1000.0 - Skill.ServerDelay;
			double requiredNotComboCd = ComboDuration - Skill.ServerDelay;
			if (requiredComboCd + Skill.LongestPause < ComboCd || requiredNotComboCd + Skill.LongestPause < NotComboCd)
			{
				Periodic = false;
                OutputPeriodic = "F";
                OutputPeriodicColor = "#FF0000";
                PauseDuration = 0.0;
                OutputPauseDuration = Math.Round(PauseDuration).ToString();
                return;
			}
            OutputPeriodic = "T";
            OutputPeriodicColor = "#0000FF";
            PauseDuration = Math.Max(ComboCd - requiredComboCd, NotComboCd - requiredNotComboCd);
			PauseDuration = Math.Max(0, PauseDuration);
			PauseDuration = Math.Ceiling(PauseDuration / 30.0) * 30.0;
            OutputPauseDuration = Math.Round(PauseDuration).ToString();
        }



	}
}
