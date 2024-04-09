using ComputerClass;
using IPhoneClass;
using LaptopClass;
using PCClass;
using SmartphoneClass;

Computer comp1 = new Computer();
Laptop laptop = new Laptop();
PC pc = new PC();
Smartphone sm1 = new Smartphone();
IPhone iphone = new IPhone();

comp1.connectDevice(pc.name);
pc.connectDevice(comp1.name);
pc.connectDevice(iphone.name);

System.Console.WriteLine($"Pc turnOn:{pc.turnOn} ");
pc.rebootGadget();
sm1.rebootGadget();
System.Console.WriteLine($"Pc turnOn after reboot:{pc.turnOn} ");
pc.showPC();

System.Console.WriteLine("Connected devices to PC:");
foreach(var item in pc.ConnectedDevices){
    System.Console.WriteLine(item);
}


Console.Read();