namespace iotCSharp
{
    internal class VacuumMachine : Device
    {
        private bool isOn = false;
        public void printStateInfo(string _info)
        {
            Console.WriteLine(_info);
        }

        public void on()
        {
            if (!isOn)
            {
                printStateInfo("Odkurzacz Włączono");
            }
            isOn = true;
        }

        public void off()
        {
            if (isOn)
            {
                printStateInfo("Odkurzacz Wyłączono");
            }
            isOn = false;

        }
    }
}
