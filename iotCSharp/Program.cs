namespace iotCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VacuumMachine vacuum = new();
            WashingMachine washing = new();

            washing.setProgram(-1);
            washing.setProgram(12);
            washing.setProgram(1);

            vacuum.on();
            vacuum.on();
            vacuum.on();

            vacuum.printStateInfo("Odkurzacz wyładował się");

            vacuum.off();
        }
    }
}
