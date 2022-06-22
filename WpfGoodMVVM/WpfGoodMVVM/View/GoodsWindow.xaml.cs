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

namespace WpfGoodMVVM.View
{
    /// <summary>
    /// GoodsWindow.xaml 的交互逻辑
    /// </summary>
    public partial class GoodsWindow : Window
    {
        public GoodsWindow(Goods goods)
        {
            InitializeComponent();
            this.DataContext = new
            {
                Model = goods
            };
        }

        private void btuSave_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void btuCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
