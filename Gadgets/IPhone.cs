using SmartphoneClass;

namespace IPhoneClass{
    internal class IPhone : Smartphone{
        public string OS { get; set; }
        
    public IPhone() : base()
    {
            OS = "iOS";
    }
}
}