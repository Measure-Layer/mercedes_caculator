using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MapleWPF
{
    /// <summary>
    /// ComboControl.xaml 的交互逻辑
    /// </summary>
    public partial class ComboControl : UserControl
    {
        public ComboControl()
        {
            InitializeComponent();
        }
        
        private void HatButton_Click(object sender, RoutedEventArgs e)
        {
            Combo combo = (Combo)DataContext;
            if (combo.HatSecondToBeSet)
            {
                combo.HatSecondColor = Brushes.Transparent;
                combo.HatSecondToBeSet = false;
            }
            else
            {
                combo.HatSecondColor = Brushes.SkyBlue;
                combo.HatSecondToBeSet = true;
            }
            
        }

        private void IrButton_Click(object sender, RoutedEventArgs e)
        {
            Combo combo = (Combo)DataContext;
            combo.FilledWithIr = !combo.FilledWithIr;
            if (combo.FilledWithIr)
            {
                combo.IrSource = "pack://application:,,,/MapleWPF;component/Images/ir.png";
                combo.OutputIrColor = "#000000";
            }
            else
            {
                combo.IrSource = "pack://application:,,,/MapleWPF;component/Images/irDisabled.png";
                combo.OutputIrColor = "#888888";
            }
        }

        private void LastDelayButton_Click(object sender, RoutedEventArgs e)
        {
            Combo combo = (Combo)DataContext;
            combo.DoesLastUseComboDelay = !combo.DoesLastUseComboDelay;
        }

        private void V2Button_Click(object sender, RoutedEventArgs e)
        {
            Combo combo = (Combo)DataContext;
            combo.Riding = !combo.Riding;
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Combo combo = (Combo)DataContext;
            Skill.RemoveCombo(combo);
        }
    }
}
