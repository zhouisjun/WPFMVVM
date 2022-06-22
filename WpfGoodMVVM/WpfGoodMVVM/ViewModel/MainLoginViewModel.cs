using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfGoodMVVM.DAL;
using WpfGoodMVVM.Model;
using System.Windows;
using WpfGoodMVVM.View;
using GalaSoft.MvvmLight;

namespace WpfGoodMVVM.ViewModel
{
   public  class MainLoginViewModel: ViewModelBase
    {
        private LoginDAL LoginDAL = new LoginDAL();

        private string userNmae;
        public string UserName
        {
            get { return userNmae; }
            set
            {
                userNmae = value;
                RaisePropertyChanged("UserName");
            }
        }
        private string pwd;
        public string Pwd
        {
            get { return pwd; }
            set
            {
                pwd = value;
                this.RaisePropertyChanged("Pwd");
            }
        }

        public MainLoginViewModel() {
            GetLogin = new RelayCommand(this.Logincommand);
            ExitLogin = new RelayCommand(this.ExitCommand);
        }

        public RelayCommand GetLogin { get; set; }
        public RelayCommand ExitLogin { get; set; }

        public void Logincommand()
        {
            
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Pwd))
            {

                bool a = LoginDAL.GetLogin(UserName, Pwd);
                if (a)
                {
                    var b = MessageBox.Show("登录成功", "提示", MessageBoxButton.OK);
                    if (b.ToString() == "OK")
                    {
                        MainWindow mainWindow = new MainWindow();
                        mainWindow.Show();
                        this.ExitCommand();
                    }

                }
                else
                {
                    MessageBox.Show("账号或密码不正确");
                }
            }
            else
            {
                MessageBox.Show("账号或者密码不能为空");
            }
        }
        public void ExitCommand() {
            Application.Current.MainWindow.Close();
        }
    }
}
