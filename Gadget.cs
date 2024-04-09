namespace GadgetInterface{
    interface IGadget{
          string name { get; }
          string price { get; }
          bool turnOn { get; set; }
        List<string> ConnectedDevices { get; set; }

        void rebootGadget();
        void connectDevice(string name);
        void disconnectDevice(string name);

    }
}