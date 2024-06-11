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
    /// TestUserControl.xaml 的交互逻辑
    /// </summary>
    public partial class TestUserControl : UserControl
    {
        private bool _valid;
        public TestUserControl()
        {
            InitializeComponent();
            _valid = false;
            UpdateView();
        }

        public void UpdateView()
        {
            if (_valid)
            {
                ToggleBorder.HorizontalAlignment = HorizontalAlignment.Right;
                InnerBorder.Background = new SolidColorBrush(Colors.LightBlue);
            }
            else
            {
                ToggleBorder.HorizontalAlignment = HorizontalAlignment.Left;
                InnerBorder.Background = new SolidColorBrush(Color.FromRgb(224, 224, 224));
            }
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            _valid = !_valid;
            UpdateView();
        }
    }
}
