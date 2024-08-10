using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
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
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            ComboListBox.ItemsSource = Skill.ComboList;

            for (int i = 1; i <= 30; ++i)
            {
                M1ComboBox.Items.Add(i);
                M2ComboBox.Items.Add(i);
                V1ComboBox.Items.Add(i);
                V2ComboBox.Items.Add(i);
            }
            M1ComboBox.SelectedIndex = 29;
            M2ComboBox.SelectedIndex = 29;
            V1ComboBox.SelectedIndex = 29;
            V2ComboBox.SelectedIndex = 29;

            Skill.LoadDefaultCombo();
        }

        //public void SelectTable(Button buttonClicked)
        //{
        //    if (_selectedButton != null)
        //    {
        //        _selectedButton.Background = new SolidColorBrush(Colors.LightBlue);
        //        _selectedButton.IsEnabled = true;
        //    }

        //    buttonClicked.Background = new SolidColorBrush(Colors.AliceBlue);
        //    buttonClicked.IsEnabled = false;

        //    _selectedButton = buttonClicked;
        //}

        //public void TableButton0Click(object sender, RoutedEventArgs e)
        //{
        //    SelectTable((Button)sender);
        //    BoardContentControl.Content = _constBoard;
        //}

        //public void TableButton1Click(object sender, RoutedEventArgs e)
        //{
        //    SelectTable((Button)sender);
        //    BoardContentControl.Content = null;
        //}

        //public void TableButton2Click(object sender, RoutedEventArgs e)
        //{
        //    SelectTable((Button)sender);
        //    BoardContentControl.Content = null;
        //}


        public void AddCombo(object sender, RoutedEventArgs e)
        {
            if (Skill.ComboList.Count >= 12)
            {
                return;
            }
            WindowAddCombo addComboWindow = new WindowAddCombo();
            addComboWindow.Left = Left + 425;
            addComboWindow.Top = Top + 300;
            if (addComboWindow.ShowDialog() == true)
            {
                Skill.AddCombo(addComboWindow.SkillList);
                //ComboControl comboControl = new ComboControl();
                //comboControl.DataContext = combo;
                //ComboControlList.Add(comboControl);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void M1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Skill.M1Level = (int)M1ComboBox.SelectedValue;
        }

        private void M2ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Skill.M2Level = (int)M2ComboBox.SelectedValue;
        }

        private void V1ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Skill.E1Level = (int)V1ComboBox.SelectedValue;
        }

        private void V2ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Skill.E2Level = (int)V2ComboBox.SelectedValue;
        }

        private void SpeedButton_Click(object sender, RoutedEventArgs e)
        {
            if (Skill.Is10)
            {
                Skill.Is10 = false;
                SpeedButton.Content = "Current Server: CMS";
                SpeedButton.Foreground = Brushes.Red;
            }
            else
            {
                Skill.Is10 = true;
                SpeedButton.Content = "Current Server: GMS";
                SpeedButton.Foreground = Brushes.Blue;
            }
        }

        private void ComboListBox_KeyDown(object sender, KeyEventArgs e)
        {
            int virtualKey = KeyInterop.VirtualKeyFromKey(e.Key);
            int virtualKeyD0 = KeyInterop.VirtualKeyFromKey(Key.D0);
            int virtualKeyN0 = KeyInterop.VirtualKeyFromKey(Key.NumPad0);
            int dDelta = virtualKey - virtualKeyD0;
            int nDelta = virtualKey - virtualKeyN0;
            if (dDelta >= 0 && dDelta <= 9)
            {
                foreach (Combo combo in Skill.ComboList)
                {
                    if (combo.HatSecondToBeSet)
                    {
                        combo.HatSecond = dDelta;
                        combo.HatSecondStr = dDelta.ToString();
                        combo.HatSecondToBeSet = false;
                        combo.HatSecondColor = Brushes.Transparent;
                    }
                }
            }
            if (nDelta >= 0 && nDelta <= 9)
            {
                foreach (Combo combo in Skill.ComboList)
                {
                    if (combo.HatSecondToBeSet)
                    {
                        combo.HatSecond = nDelta;
                        combo.HatSecondStr = nDelta.ToString();
                        combo.HatSecondToBeSet = false;
                        combo.HatSecondColor = Brushes.Transparent;
                    }
                }
            }
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            WindowHelp windowHelp = new WindowHelp();
            windowHelp.Left = Left + 400;
            windowHelp.Top = Top + 275;
            windowHelp.ShowDialog();
        }
    }
}
