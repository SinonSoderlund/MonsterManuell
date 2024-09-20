using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class MenuRunner
    {
        /// <summary>
        /// Maps menu options
        /// </summary>
        public enum MenuSelector
        {
            CreatePerson = 1,
            PersonPrinter = 2,
            ErrorSpinner = 3,
            Geeser = 4,
            Exit = 0
        }
        /// <summary>
        /// Runs the program
        /// </summary>
        public void Run()
        {
            PersonHandler personHandler = new PersonHandler();

            while (true)
            {
                ShowMainMenu();
                switch ((MenuSelector)ConsoleUtils.GetIntSilent("Number"))
                {
                    case MenuSelector.CreatePerson:
                        personHandler.ConsoleAddPerson();
                        break;
                    case MenuSelector.PersonPrinter:
                        personHandler.PrintAll();
                        break;
                    case MenuSelector.ErrorSpinner:
                        TheErrorSpinner();
                        break;
                    case MenuSelector.Geeser:
                        TheGeeseCommeth();
                        break;
                    case MenuSelector.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nUnrecognized input, press enter to continue and try again.");
                        Console.ReadLine();
                        break;
                }
            }

        }
        /// <summary>
        /// Clears the console and shows the main menu text
        /// </summary>
        public static void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine($"Welcome to the Monster Manuell!\nWhat services would you like to make use of today?\n{((int)MenuSelector.CreatePerson)}: Create Person - Create a person for our fabulous Person Handler!\n{((int)MenuSelector.PersonPrinter)}: Person Printer - Show all the people youve created!\n{((int)MenuSelector.ErrorSpinner)}: Error Spinner - Want to read a bunch of random error messages? Yeah you sure do!\n{((int)MenuSelector.Geeser)}: The Geese Commeth - The animals are comming, i would run if i were you.\n{((int)MenuSelector.Exit)}: Exit program");
        }

        public void TheErrorSpinner()
        {
            List<UserError> userErrors = new() {
            new NumericalInputError(),
            new TextInputError(),
            new TextInputError(),
            new NumericalInputError(),
            new DroidError(),
            new _2Error(),
            new ErrorError()};
            foreach (var error in userErrors)
            {
                Console.WriteLine(error.UEMessage());
            }
            ConsoleUtils.WaitToContinue();
        }

        public void TheGeeseCommeth()
        {
            List<Animal> Animals = new()
            {
                new Bird("Jom", 145d, 5, 200),
                new Pelican("joan", 1d, 3, 0, 4000000),
                new WolfMan("Tommothy", 50, 24, 16d),
                new Dog("Greg", 200, 1, 57),
                new Worm("Worm", 3073, 1),
                new Horse("Tobias Reaper", 70, 47, 13),
                new Hedgehog("Smol bean", 5,4,true),
                new Swan("Sean bean", 34,34, 34,34)
            };
            foreach (Animal animal in Animals)
            {
                Console.WriteLine(animal.GetType().Name);
                //Q: 13 we get the overwritten stats class, not the abstract one which lacks an implementation, most specific implementation always grabbed
                if (animal is Dog animaldog)
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(animaldog.arf("p"));
                }
                //Q 17: arff is not a member function of animal, and therefore not available via animal invocation
                //animal.arff();
                animal.DoSound();
                if(animal is IPerson)
                {
                    ((IPerson)animal).Talk();
                }
            }
            ConsoleUtils.WaitToContinue();
        }

        //public void TheWorstShowInTown()
        //{
        //    //Q 9: A Horse is not a dog, inheriting members may be treated as their parents, but not as their "Siblings"
        //    //Q 10 : if we wanted to add a horse then we need an animal list,or a list of a shared horse-dog interface
        //    List<Dog> Hell = new()
        //    {

        //    }
        //}
    }
}