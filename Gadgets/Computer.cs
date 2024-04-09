using GadgetInterface;
using System.Threading;

namespace ComputerClass{
    internal class Computer:IGadget{
        public string name { get; set; }
        public string price { get; set; }   
        public string CPU {get; set; }
        public string Motherboard {get; set; }
        public string RAM {get; set; }
        public string GraphicCard {get; set; }

        public bool turnOn{ get; set; }

        public List<string> ConnectedDevices { get; set; }

        public void connectDevice(string nameOfDevice)
        {
            ConnectedDevices.Add(nameOfDevice);
        }
        public void disconnectDevice(string nameOfDevice)
        {
            ConnectedDevices.RemoveAll(item => item == nameOfDevice);
        }

        public void rebootGadget(){
            Timer timer = null;
            turnOn = false;

            timer = new Timer(_ =>
            {
                turnOn = true;
                timer?.Dispose();
            }, null, TimeSpan.FromSeconds(1), Timeout.InfiniteTimeSpan);

        }

        public Computer(){
            name = "Comp";
            price = "2500$";
            CPU = "Ryzen";
            GraphicCard = "Nvidia RTX 4090";
            Motherboard = "Asus";
            RAM = "32GB";

            turnOn = true;
            ConnectedDevices = new List<string> {};
        }

        public Computer(string name,string price,string CPU,string GraphicCard,string Motherboard,string RAM){
            this.name = name;
            this.price = price;
            this.CPU = CPU;
            this.GraphicCard = GraphicCard;
            this.Motherboard = Motherboard;
            this.RAM = RAM;

            turnOn = true;
            ConnectedDevices = new List<string> {};
        }
        
    }
}