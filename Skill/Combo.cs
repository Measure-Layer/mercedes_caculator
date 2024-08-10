using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace MapleWPF
{
    internal partial class Combo
    {
		// 用户可以选择是否填充伊师塔、是否启用尾技能无后摇，以及选择CD头秒数
		// 当技能延迟与CD满足循环条件时，自动设为循环，否则设为不循环
		// 在不循环状态时，可启用尾技能无后摇，可选择是否填充伊师塔
        public readonly List<string> SkillList = new List<string>();

		public Combo()
		{
			
		}

		public Combo(List<string> skillList)
        {
            SkillList = new List<string>(skillList);
            UpdateUI();
            UpdateOriginCd();
            UpdateCd();
            UpdateComboDuration();
            UpdateAllComboPctg();
            UpdateCanBeRiding();
            UpdatePeriodic();
            UpdateIr();
            UpdateIrPctg();
            UpdateTotalDuration();
            UpdateE2Pctg();
            UpdateV1tPctg();
            UpdateOutput();
            Skill.UpdateCombo();
        }
	}
}
