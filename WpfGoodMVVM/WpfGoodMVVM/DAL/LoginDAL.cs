using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfGoodMVVM.Model;

namespace WpfGoodMVVM.DAL
{
    class LoginDAL
    {
        private List<Login> Logins;
        public LoginDAL() {
            InitLogin();
        }
        private void InitLogin() {
            Logins = new List<Login>
            {
                new Login{UserID=1,UserName="maind",Password="1234578" },
                new Login{UserID=2,UserName="maind2",Password="123" },
                new Login{UserID=3,UserName="maind3",Password="1234" },
                new Login{UserID=4,UserName="maind4",Password="12345" },
            };
        }
        
        public bool GetLogin(string user,string pwd) {
            var item = Logins.FirstOrDefault(L => L.UserName == user && L.Password == pwd);
            if (item!=null)
            {
                return true;
            }
            return false;
        }

    }
}
