using System.Text.RegularExpressions;
using System.Text;
namespace MonsterManuell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    new MenuRunner().Run();
                }
                catch (ArgumentException argRegOut)
                {
                    Console.WriteLine(argRegOut.StackTrace);
                    Console.WriteLine(argRegOut.Message);
                    if (ConsoleUtils.QuitProgramAsk())
                        break;
                }
            }
        }
    }
}
