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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void button1_Click(object sender, EventArgs e)
        { //giriş yap buttonu tıklandığında 
            User user = new User(); //user sınıfından user nesnesi ürettik
            user.UserName = txtUsername.Text;
            user.password = TxtPassword.Text;
            //kullanıcının giriş tarihinide alıcaz
            string loginDate = DateTime.Now.ToString(); //sistem zamanını alır
            user.Login(loginDate);
            Login login = new Login(user); //login formu yarattık user nesnesini döndüren 
            login.Show(); //2.formu gösterir  
            this.Hide(); //şu anki 1 formu gizler
        }
    }
}
