using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkW2.ConsoleApp
{
    public interface ITakePhoto
    {
        public abstract void TakePhoto();
    }
    public abstract class Phone
    {

        public void Call()
        {
            Console.WriteLine("Calling");
        }
    }

    public class IPhone : Phone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Taking Photo");
        }
    }
    public class Nokia : Phone
    {
    }
}
