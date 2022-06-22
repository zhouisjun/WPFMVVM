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
using WpfGoodMVVM.Model;
using WpfGoodMVVM.ViewModel;

namespace WpfGoodMVVM.View
{
    /// <summary>
    /// LoginWindows.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindows : Window
    {
        
        public LoginWindows()
        {
            InitializeComponent();
            MainLoginViewModel Login = new MainLoginViewModel();
            this.DataContext = Login;
        }

    }
}
