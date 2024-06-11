using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace MapleWPF
{
    public class SkillLevelTextBox : TextBox
    {

        public SkillLevelTextBox()
        {
            this.PreviewTextInput += SkillLevelTextBox_PreviewTextInput;
            DataObject.AddPastingHandler(this, SkillLevelTextBox_Paste);
        }

        private void SkillLevelTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string old_text = textBox.Text;
            string append_text = e.Text;

            if (old_text.Length + append_text.Length >= 3)
            {
                e.Handled = true;
                return;
            }

            string validChars = "0123456789";
            foreach (char c in append_text)
            {
                if (!validChars.Contains(c))
                {
                    e.Handled = true;
                    return;
                }
            }
        }

        private void SkillLevelTextBox_Paste(object sender, DataObjectPastingEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            string oldText = textBox.Text;
            string pasteText = e.DataObject.GetData(typeof(string)) as string;

            if (oldText.Length + pasteText.Length >= 3)
            {
                e.CancelCommand();
                return;
            }

            TabControl tabControl = sender as TabControl;

            string validChars = "0123456789";
            foreach (char c in pasteText)
            {
                if (!validChars.Contains(c))
                {
                    e.CancelCommand();
                    return;
                }
            }
        }

        public CornerRadius TextBoxCornerRadius
        {
            get { return (CornerRadius)GetValue(TextBoxCornerRadiusProperty); }
            set { SetValue(TextBoxCornerRadiusProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextBoxCornerRadiusProperty =
            DependencyProperty.Register("TextBoxCornerRadius", typeof(CornerRadius), typeof(SkillLevelTextBox));
    }
}
