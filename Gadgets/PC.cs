using ComputerClass;

namespace PCClass{
    internal class PC:Computer{
        public string monitor {get;set;}
        public string keyboard { get; set; }
        public string mouse {get; set;} 
        public string headphones {get; set;}
        public string microphone{get; set;} 

        public PC()
        :base(){
            name = "Cool PC";
            monitor = "LG MP405";
            keyboard = "Hator Rockfall";
            mouse = "HyperX pulsefire";
            headphones = "Logitech G735";
            microphone = "Fifine A8";
        }

        public void showPC() { 
            Console.WriteLine($"Microphone:{microphone}, monitor:{monitor},keyboard:{keyboard},mouse:{mouse},headphones:{headphones},CPU:{CPU},RAM:{RAM},GraphicCard:{GraphicCard},price:{price}");
        }
    }
}