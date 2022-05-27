using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2. Use /Abstraction/ to define different classes for each person type such as Student
and Instructor. These classes should have behavior for that type of person.
3. Use /Encapsulation/ to keep many details private in each class.
4. Use /Inheritance/ by leveraging the implementation already created in the Person
class to save code in Student and Instructor classes.
5. Use /Polymorphism/ to create virtual methods that derived classes could override to
create specific behavior such as salary calculations.*/

namespace Assignment3
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string Address { get; set; }

        public virtual void Descripion()
        {
            Console.WriteLine("This is a person");
        }
    }

    public class Student : Person
    {
        public int StudentId { get; set; }
        private int Gpa { get; set; }

        public override void Descripion()
        {
            Console.WriteLine("This is a student");
        }
    }

    public class Instructor : Person
    {
        public int InstructorId { get; set; }
        private int Salary { get; set; }

        public override void Descripion()
        {
            Console.WriteLine("This is a instructor");
        }
    }
}
