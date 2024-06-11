using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Combo
    {
        private bool _riding;

        public bool Riding
        {
            get { return _riding; }
            set
            {
                _riding = value;
                UpdateV2Source();
                UpdateOutput();
                Skill.UpdateCombo();
            }
        }

        public bool CanBeRiding;

        public void UpdateCanBeRiding()
        {
            CanBeRiding = true;
            foreach (var skillName in SkillList)
            {
                if (!Skill.CanRiderUseDict[skillName])
                {
                    CanBeRiding = false;
                    return;
                }
            }
            UpdateV2Source();
        }
    }
}
