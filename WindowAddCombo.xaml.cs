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
using System.Windows.Shapes;

namespace MapleWPF
{
    /// <summary>
    /// WindowAddCombo.xaml 的交互逻辑
    /// </summary>
    public partial class WindowAddCombo : Window
    {
        public List<string> SkillList = new List<string>();
        public WindowAddCombo()
        {
            InitializeComponent();
            
        }

        private void okButton_Click(object sender, RoutedEventArgs e)
        {
            SkillList.Clear();
            string input = inputTextBox.Text;
            if (input.Length == 0)
            {
                DialogResult = true;
                Close();
                return;
            }
            int idx = 0;
            while (idx < input.Length)
            {
                if (idx + 1 >= input.Length)
                {
                    break;
                }
                string skillName = input.Substring(idx, 2);
                if (Skill.SkillNameList.Contains(skillName))
                {
                    SkillList.Add(skillName);
                }
                else
                {
                    MessageBox.Show("\"" + skillName + "\" is not a skill! ", "Error Input", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }
                idx += 3;
            }
            DialogResult = true;
            Close();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                okButton_Click(sender, e);
                e.Handled = true;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (inputTextBox.IsVisible)
            {
                Keyboard.Focus(inputTextBox);
            }
        }
    }
}
