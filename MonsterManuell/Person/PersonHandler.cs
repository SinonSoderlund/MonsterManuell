using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterManuell
{
    internal class PersonHandler
    {
        private List<Person> persons = new();

        /// <summary>
        /// Sets the age of the supplied person
        /// </summary>
        /// <param name="person">person reference</param>
        /// <param name="age">new age for person, should be greater than 0</param>
        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        /// <summary>
        /// calls the person constructor
        /// </summary>
        /// <param name="age">int, must be greater than 0</param>
        /// <param name="height">height</param>
        /// <param name="weight">weight</param>
        /// <param name="fName">first name, must be longer than Person.FNAME_MIN and shorter then Person.FNAME_MAX</param>
        /// <param name="lName">last name, must be longer than Person.LNAME_MIN and shorter then Person.LNAME_MAX</param>
        public Person CreatePerson(int age, double height, double weight, string fName, string lName)
        {
            return new Person(age, height, weight, fName, lName);
        }

        /// <summary>
        /// creates new person and adds it to the personhandler list
        /// </summary>
        /// <param name="age">int, must be greater than 0</param>
        /// <param name="height">height</param>
        /// <param name="weight">weight</param>
        /// <param name="fName">first name, must be longer than Person.FNAME_MIN and shorter then Person.FNAME_MAX</param>
        /// <param name="lName">last name, must be longer than Person.LNAME_MIN and shorter then Person.LNAME_MAX</param>
        public void AddPerson(int age, double height, double weight, string fName, string lName)
        {
            AddPerson(CreatePerson(age, height, weight, fName, lName));
        }
        /// <summary>
        /// adds person to the personhandler list
        /// </summary>
        /// <param name="person"></param>
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        /// <summary>
        /// Creates a new person using consolUtils Prompts
        /// </summary>
        public void ConsoleAddPerson()
        {
            Console.WriteLine("Hello and welcome to the person creation process, please follow the instructions anf persorm the following steps:");
            Person temp = CreatePerson(ConsoleUtils.GetRangeCheckedInputInt("Age",1, int.MaxValue, "Please Input a greater than 0 valid"),
                ConsoleUtils.GetInputDouble("Height", "Please input a valid"),
                ConsoleUtils.GetInputDouble("Weight", "Please input a valid"),
                StringUtils.ConsoleStringLenghtValidator("First Name", Person.FNAME_MIN, Person.FNAME_MAX, $"Please enter a valid first name with conditions maxlenght = {Person.FNAME_MAX}, minlenght = {Person.FNAME_MIN}, please enter the"),
                StringUtils.ConsoleStringLenghtValidator("Last Name", Person.FNAME_MIN, Person.FNAME_MAX, $"Please enter a valid last name with conditions maxlenght = {Person.LNAME_MAX}, minlenght = {Person.LNAME_MIN}, please enter the"));
            if (ConsoleUtils.GetInputbool("Answer", "1", "2", $"Is this  the person you want to add to the personhandler? \n {temp} \nPress '1' is yes, '2' if no, please enter your"))
            {
                AddPerson(temp);
                Console.WriteLine("Person added!");
            }
            ConsoleUtils.WaitToContinue();
        }

        /// <summary>
        /// Prints out all persons in person list
        /// </summary>
        public void PrintAll()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
            ConsoleUtils.WaitToContinue();
        }
    }
}
