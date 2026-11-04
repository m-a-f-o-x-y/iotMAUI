namespace iotCSharp
{
    internal class WashingMachine : Device
    {
        private int program = 0;
        public void setProgram(int _new)
        {
            if (_new < 0 || _new > 12)
            {
                program = 0;
                printStateInfo("Nieprawidłowy numer programu");
            }
            else
            {
                program = _new;
                printStateInfo($"Ustawiono program {program}");
            }
        }

        public void printStateInfo(string _info)
        {
            Console.WriteLine(_info);
        }
    }
}
