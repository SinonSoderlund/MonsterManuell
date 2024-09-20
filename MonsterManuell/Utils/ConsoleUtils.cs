using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal static class ConsoleUtils
    {
        /// <summary>
        /// Function to request and retreive desired string type data from a user via console
        /// </summary>
        /// <param name="RequestedInput">The type of input that is desired from the user</param>
        /// <param name="acceptBlank">Controlls if a blank or otherwise empty return string is accepted, default no</param>
        /// <param name="additionalPrompt">Preface text to give additional context to the thing being requested, for example if age is requested then a suitable additionalPrompt me be 'please enter your', will be exluded by default</param>
        /// <returns>The validated console input</returns>
        public static string GetInputString(string RequestedInput, bool acceptBlank = false, string additionalPrompt = "")
        {
            if (string.IsNullOrEmpty(additionalPrompt))
                Console.WriteLine(RequestedInput);
            else
                Console.WriteLine($"{additionalPrompt} {RequestedInput}");
            if (!acceptBlank)
                while (true)
                {
                    string input = Console.ReadLine()!;
                    if (!string.IsNullOrWhiteSpace(input))
                        return input;
                    else
                        ValidRequestor(RequestedInput);
                }
            else
                return Console.ReadLine()!;
        }
        /// <summary>
        ///  Runs GetInputString And then converts it into a valid int
        /// </summary>
        /// <param name="RequestedInput">The type of input that is desired from the user</param>
        /// <param name="additionalPrompt">Preface text to give additional context to the thing being requested, for example if age is requested then a suitable additionalPrompt me be 'please enter your', exluded by default</param>
        /// <returns>A valid int value</returns>
        public static int GetInputInt(string RequestedInput, string additionalPrompt = "")
        {
            while (true)
            {
                if (int.TryParse(GetInputString(RequestedInput, false, additionalPrompt), out int input))
                {
                    return input;
                }
                else
                    ValidRequestor(RequestedInput);
            }
        }
        public static int GetRangeCheckedInputInt(string RequestedInput, int min, int max, string additionalPrompt = "")
        {
            while (true)
            {
                int.TryParse(GetInputString(RequestedInput, false, additionalPrompt), out int input);
                if (input <= max && input >= min)
                {
                    return input;
                }
                else
                {
                    bool select = input > max;
                    Console.WriteLine($"Please enter a valid number {(select ? "Lesser" : "Greater")} than or equal to {(select ? max : min)}");
                }

            }
        }
        /// <summary>
        /// Runs GetInputString And then converts it into a valid double
        /// </summary>
        /// <param name="RequestedInput">The type of input that is desired from the user</param>
        /// <param name="additionalPrompt">Preface text to give additional context to the thing being requested, for example if age is requested then a suitable additionalPrompt me be 'please enter your', exluded by default</param>
        /// <returns>A valid double value</returns>
        public static Double GetInputDouble(string RequestedInput, string additionalPrompt = "")
        {
            while (true)
            {
                if (Double.TryParse(GetInputString(RequestedInput, false, additionalPrompt), out double input))
                {
                    return input;
                }
                else
                    ValidRequestor(RequestedInput);
            }
        }
        /// <summary>
        /// Function for querying the user for an answer, presenting a yes and no option and returning true or false based on answer
        /// </summary>
        /// <param name="RequestedInput">Generally just 'Answer'</param>
        /// <param name="returnTrueIfEqual">the value to be entered for yes</param>
        /// <param name="returnFalseIfEqual">the value to be entered for no</param>
        /// <param name="additionalPrompt">the actual question being asked, most often</param>
        /// <returns>true or false</returns>
        public static bool GetInputbool(string RequestedInput, string returnTrueIfEqual, string returnFalseIfEqual, string additionalPrompt = "")
        {
            while (true)
            {
                string input = GetInputString(RequestedInput, false, additionalPrompt);
                if (input == returnTrueIfEqual)
                    return true;
                else if (input == returnFalseIfEqual)
                    return false;
                else
                    ValidRequestor(RequestedInput);
            }
        }
        /// <summary>
        /// Function for getting an int without an initial prompt
        /// </summary>
        /// <param name="RequestedInput">the input that was requested, only displayed if the user inputs a non-int</param>
        /// <returns></returns>
        public static int GetIntSilent(string RequestedInput)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    return input;
                }
                else
                    ValidRequestor(RequestedInput);
            }
        }
        /// <summary>
        /// Short function that displays a request for the user to input a valid value
        /// </summary>
        /// <param name="RequestedInput">The type of input that is desired from the user</param>
        public static void ValidRequestor(string RequestedInput)
        {
            Console.WriteLine($"Please input a valid {RequestedInput}");
        }
        /// <summary>
        /// Asks user if they want to quit, returns true if they enter 1 
        /// </summary>
        /// <returns></returns>
        public static bool QuitProgramAsk()
        {
            if (GetInputString("Answer", true, "Do you want to quit the program? If no, input anything other than '1', else press 1 and enter your") == "1")
                return true;
            else return false;
        }

        /// <summary>
        /// Simple function to stall program until user presses enter
        /// </summary>
        public static void WaitToContinue()
        {
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }
    }
}
