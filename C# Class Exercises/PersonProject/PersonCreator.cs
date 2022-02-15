using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonProject
{
    class PersonCreator
    {

        private Person somePerson;
        private Person anotherPerson;


        public void RunProgram()
        {
            somePerson = new Person(35, "Fred", 1.71);

            somePerson.Age = -27;

            anotherPerson = new Person(30, "Jayne", 1.52);


            Console.WriteLine("The name of the somePerson object is: {0} and age is {1}, Height is {2}.", somePerson.Name, somePerson.Age, somePerson.Height);
            Console.WriteLine("The name of the anotherPerson object is: {0} and age is {1}, Height is {2}.", anotherPerson.Name, anotherPerson.Age, anotherPerson.Height);

            somePerson.GrowOlder();
            anotherPerson.GrowOlder();

            Console.WriteLine("The name of the somePerson object is: {0} and age is {1}, Height is {2}.", somePerson.Name, somePerson.Age, somePerson.Height);
            Console.WriteLine("The name of the anotherPerson object is: {0} and age is {1}, Height is {2}.", anotherPerson.Name, anotherPerson.Age, anotherPerson.Height);
        }


        static void Main(string[] args)
        {

            PersonCreator myPersonCreator = new PersonCreator();
            myPersonCreator.RunProgram();


            Console.WriteLine("\n\n===============================");
            Console.WriteLine("PersonCreator: Press any key to finish");
            Console.ReadKey();

        }
    }
}
