using ComputerClass;

namespace LaptopClass{
    internal class Laptop:Computer{
        public string color {get;set;}  
        public Laptop():base(){
            name = "MacBook Pro 13";
            color = "white";
        }
    }
}