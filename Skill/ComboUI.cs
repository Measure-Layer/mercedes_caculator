using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace MapleWPF
{
    internal partial class Combo : INotifyPropertyChanged
    {
        private string _order;

        public string Order
        {
            get { return _order; }
            set
            {
                _order = value;
                OnPropertyChanged(nameof(Order));
            }
        }

        public string ImgSource0 { get; set; }
        public string ImgSource1 { get; set; }
        public string ImgSource2 { get; set; }
        public string ImgSource3 { get; set; }
        public string ImgSource4 { get; set; }
        public string ImgSource5 { get; set; }
        public string ImgSource6 { get; set; }
        public string ImgSource7 { get; set; }
        private string _irSource;

        public string IrSource
        {
            get { return _irSource; }
            set
            {
                _irSource = value;
                OnPropertyChanged(nameof(IrSource));
            }
        }

        private string _outputIrCount;

        public string OutputIrCount
        {
            get { return _outputIrCount; }
            set
            {
                _outputIrCount = value;
                OnPropertyChanged(nameof(OutputIrCount));
            }
        }

        private string _outputIrColor;

        public string OutputIrColor
        {
            get { return _outputIrColor; }
            set
            {
                _outputIrColor = value;
                OnPropertyChanged(nameof(OutputIrColor));
            }
        }

        public void UpdateUI()
        {
            Order = 0.ToString();
            ImgSource0 = "";
            ImgSource1 = "";
            ImgSource2 = "";
            ImgSource3 = "";
            ImgSource4 = "";
            ImgSource5 = "";
            ImgSource6 = "";
            ImgSource7 = "";
            string sourcePre = "pack://application:,,,/MapleWPF;component/Images/";
            string sourceAdd = ".png";
            int skillCount = SkillList.Count;
            if (skillCount >= 1)
            {
                ImgSource0 = sourcePre + SkillList[0] + sourceAdd;
            }
            if (skillCount >= 2)
            {
                ImgSource1 = sourcePre + SkillList[1] + sourceAdd;
            }
            if (skillCount >= 3)
            {
                ImgSource2 = sourcePre + SkillList[2] + sourceAdd;
            }
            if (skillCount >= 4)
            {
                ImgSource3 = sourcePre + SkillList[3] + sourceAdd;
            }
            if (skillCount >= 5)
            {
                ImgSource4 = sourcePre + SkillList[4] + sourceAdd;
            }
            if (skillCount >= 6)
            {
                ImgSource5 = sourcePre + SkillList[5] + sourceAdd;
            }
            if (skillCount >= 7)
            {
                ImgSource6 = sourcePre + SkillList[6] + sourceAdd;
            }
            if (skillCount >= 8)
            {
                ImgSource7 = sourcePre + SkillList[7] + sourceAdd;
            }
            IrSource = sourcePre + "irDisabled.png";
            OutputIrColor = "#888888";
            OutputLastRecovery = "F";
            OutputLastRecoveryColor = "#FF0000";
            V2Source = "pack://application:,,,/MapleWPF;component/Images/v2Disabled.png";
            HatSecondColor = Brushes.Transparent;
            HatSecondStr = "0";
        }
        private string _hatSecondStr;

        public string HatSecondStr
        {
            get { return _hatSecondStr; }
            set
            {
                _hatSecondStr = value;
                OnPropertyChanged(nameof(HatSecondStr));
            }
        }

        private string _outputPeriodic;

        public string OutputPeriodic
        {
            get { return _outputPeriodic; }
            set
            {
                _outputPeriodic = value;
                OnPropertyChanged(nameof(OutputPeriodic));
            }
        }

        private string _outputPeriodicColor;

        public string OutputPeriodicColor
        {
            get { return _outputPeriodicColor; }
            set
            {
                _outputPeriodicColor = value;
                OnPropertyChanged(nameof(OutputPeriodicColor));
            }
        }


        private string _outputPauseDuration;

        public string OutputPauseDuration
        {
            get { return _outputPauseDuration; }
            set
            {
                _outputPauseDuration = value;
                OnPropertyChanged(nameof(OutputPauseDuration));
            }
        }

        private string _outputLastRecovery = "F";

        public string OutputLastRecovery
        {
            get { return _outputLastRecovery; }
            set
            {
                _outputLastRecovery = value;
                OnPropertyChanged(nameof(OutputLastRecovery));
            }
        }

        private string _outputLastRecoveryColor;

        public string OutputLastRecoveryColor
        {
            get { return _outputLastRecoveryColor; }
            set
            {
                _outputLastRecoveryColor = value;
                OnPropertyChanged(nameof(OutputLastRecoveryColor));
            }
        }

        private string _outputTotalDuration;

        public string OutputTotalDuration
        {
            get { return _outputTotalDuration; }
            set
            {
                _outputTotalDuration = value;
                OnPropertyChanged(nameof(OutputTotalDuration));
            }
        }

        private string _v2Source;

        public string V2Source
        {
            get { return _v2Source; }
            set
            {
                _v2Source = value;
                OnPropertyChanged(nameof(V2Source));
            }
        }

        public void UpdateV2Source()
        {
            if (CanBeRiding && Riding)
            {
                V2Source = "pack://application:,,,/MapleWPF;component/Images/v2.png";
            }
            else
            {
                V2Source = "pack://application:,,,/MapleWPF;component/Images/v2Disabled.png";
            }
        }

        private string _outputOutputNormal;

        public string OutputOutputNormal
        {
            get { return _outputOutputNormal; }
            set
            {
                _outputOutputNormal = value;
                OnPropertyChanged(nameof(OutputOutputNormal));
            }
        }

        private string _outputOutputV1;

        public string OutputOutputV1
        {
            get { return _outputOutputV1; }
            set
            {
                _outputOutputV1 = value;
                OnPropertyChanged(nameof(OutputOutputV1));
            }
        }

        private string _outputNormalRate;

        public string OutputNormalRate
        {
            get { return _outputNormalRate; }
            set
            {
                _outputNormalRate = value;
                OnPropertyChanged(nameof(OutputNormalRate));
            }
        }

        private string _outputV1Rate;

        public string OutputV1Rate
        {
            get { return _outputV1Rate; }
            set
            {
                _outputV1Rate = value;
                OnPropertyChanged(nameof(OutputV1Rate));
            }
        }

        public bool HatSecondToBeSet = false;

        private SolidColorBrush _hatSecondColor;

        public SolidColorBrush HatSecondColor
        {
            get { return _hatSecondColor; }
            set
            {
                _hatSecondColor = value;
                OnPropertyChanged(nameof(HatSecondColor));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
