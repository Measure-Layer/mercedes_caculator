using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleWPF
{
    internal partial class Skill
    {
        private static int _m2Level = 1;
        public static int M2Level
        {
            get { return _m2Level; }
            set
            {
                _m2Level = value;
                UpdateWePctg();
                UpdateSrPctg();
                UpdateLtPctg();
                UpdateAllCompPctg(we);
                UpdateAllCompPctg(sr);
                UpdateAllCompPctg(lt);
            }
        }
        public static void UpdateWePctg()
        {
            
        }
        public static void UpdateSrPctg()
        {
            
        }
        public static void UpdateLtPctg()
        {
            
        }

        public static void InitM2()
        {
            M2Level = 1;
        }
    }
}
