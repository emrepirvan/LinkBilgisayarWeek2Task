
//Ben SOLID presiplerini doğrudan hocanın anlattığı gibi değilde Üretim sektöründen Örnek üzerinden anlatmak İstedim

using LinkW2.ConsoleApp;
using static LinkW2.ConsoleApp.Phone;
//Bizim Genel bir Machining yani işleme prossesimiz var 


IMachiningRepository pr = new LaserCutRepository();
//ImalatHanede Bir satın alma yapıp Eskiden yüksek maliyetle yaptığımız Laser kesim yerine
//Daha Ucuz olan Frezeye geçmek istediğimizde
//Biz sadece imalathane içinde boş bir alana CNC Frezeyi yerleştirdik. Üretim Alanındaki Olan düzeni değiştirmeden İşimizi büyüttük 
//Özetle Biz değişiklik yaptığımızda Service katmanımıza hiç müdahale etmeden ihtiyaçlarımızı karşıladık (dependency inversion) 
pr = new CNCMillingRepository();
//(Aynı zamanda bu örnek OPEN CLOSED Prensibini de Örneklemiş olur) 

// Dependency Injection Conteiner/ Inversion of conteiner  Web API Tarafında aktif olarak kullanılmıştır

MachiningService ps = new MachiningService(pr);
// _____________________________________________________________________________________


ps.GetProductNames();

Console.WriteLine(String.Join(",", ps.GetProductNames()));



//solid liskov substitution principle__________________________



Phone phone = new IPhone();

phone.Call();

//phone = new Nokia();

phone.Call();
((ITakePhoto)phone).TakePhoto();



