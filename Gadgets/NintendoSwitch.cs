using ComputerClass;

namespace NintendoClass{
    internal class Nintendo:Computer{
        public string color {get;set;}  
        public Nintendo():base(){
            name = "Nintendo Switch";
            color = "red";
        }
    }
}