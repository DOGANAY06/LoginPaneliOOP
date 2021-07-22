using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginOOP
{
    public partial class Login : Form
    {
        public Login(User _user) //gelen user tuttum form1 den  aldım 
        {
            InitializeComponent();
            user = _user; //user nesnesini döndürecek
        }

        User user;
        private void Login_Load(object sender, EventArgs e)
        {//gelen kullanıcı label yazılacak
            lblmesaj.Text = "Hoşgeldiniz " + user.UserName; //loginde yazacak olan text mesajı
        }
    }
}
