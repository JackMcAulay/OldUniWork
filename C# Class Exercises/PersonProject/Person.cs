using System;

using System.Text;


namespace PersonProject
{
  public class Person
    {

        private int age;
        private string name;
        private double height;


        public Person()
        {
            age = 0;
            name = "no name yet";
        }

        public Person(string personName)
        {
            age = 0;
            Name = personName;
        }

        public Person(int initialAge, string personName)
        {
            age = initialAge;
            Name = personName;
        }

        public Person(int initialAge, string personName, double personHeight)
        {
            age = initialAge;
            Name = personName;
            height = personHeight;
        }

        public void GrowOlder()
        {
            age++;
            height -= 0.01;
        }

        public string Name
        {
            set { name = value; }

            get { return name; }

        }

        public int Age
        {
            set { if (value > 0)
                    age = value;
            }

            get { return age; }

        }

        public double Height
        {
            set { height = value; }

            get { return height; }

        }

    } // end class Person
}
