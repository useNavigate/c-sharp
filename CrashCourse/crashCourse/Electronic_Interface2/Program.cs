using Electronic_Interface2;

namespace ElectronicExample 
{
    class Program 
    { 
        static void Main(string[] args) 
        {
            IElectronicDevice TV = TvRemote.GetDevice();
            PowerButton powerButton = new PowerButton(TV);
            powerButton.Execute();
            powerButton.Undo();

        }
    
    }


}