using GadgetInterface;

namespace SmartphoneClass{
    internal class Smartphone:IGadget{
        public string name { get; set; }
        public string price { get; set; }   
        public string color {get; set; }
        public string camera {get; set; }
        public string RAM {get; set; }
        public string size {get; set; }

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
            }, null, TimeSpan.FromSeconds(10), Timeout.InfiniteTimeSpan);

        }

        public Smartphone(){
            name = "smartphone";
            price = "1000$";
            color="blue";
            camera = "32mp";
            RAM = "3GB";
            size = "big";
        }

        public Smartphone(string name,string price,string color,string camera,string RAM,string size){
            this.name = name;
            this.price = price;
            this.color = color;
            this.camera = camera;
            this.RAM = RAM;
        }
    }
}