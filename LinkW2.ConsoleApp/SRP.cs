using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{//Single Responsibility Principle
    //Bu Prensipte  Bir kod bloğu birden fazla Yerde kullanılan Kodu tek bir Metottan kontrol etmeli
    /// Sınıf seviyesinde ise Her sınıfın için o sınıfla ilgili Kodlar bulunmalı
    /// Katman Seviyesinde ise Örneğin database işlemleri ilgili katmanda bulunmalı
    /// 
    /// </summary>
    public class Message
    {
        public string MessageTitle { get; set; }
        public string MessageBody { get; set; }
        public void ChangePassword()
        {
            //Logic
        }
        public void SendMessage()
        {
            //Logic
        }
        //Örneğin burda ChangePassword metodu ayrı olarak User işlemleri tanımlanım ayrı bir sınıfta ele alınmalı

    }
}
