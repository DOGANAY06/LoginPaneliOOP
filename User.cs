using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginOOP
{
    public class User //user classı 
    {
        public string UserName { get; set; } //değerleri alma ve okuma
        public string  password { get; set; }
   

        public void Login(string loginDate) //Giriş işlemi için gereken metot zaman değerini döndürür 
        {
            MessageBox.Show(loginDate + " Tarihinde " + UserName + " adlı kullanıcı " + password +" şifresi ile giriş yapmıştır ");
            //ekrana tarihi kullanıcıyı şifresini yazar
        }
    }
}
