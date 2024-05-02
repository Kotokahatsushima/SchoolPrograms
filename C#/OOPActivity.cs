using System;
class Driver
{
    public class Human 
    {
        string name;
        int age;


        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Talk(string sentence)
        {
            Console.WriteLine("The Human Talked and said: "+ sentence);
        }
    }


    public class Student : Human
    {
        string student_ID;
        public Student(string name, int age, string student_ID) : base (name, age)
        {
            this.student_ID = student_ID;
        }

        public override void Talk(string Sentence)
        {
            base.Talk(Sentence);
        }
    }


    public class Instructor : Human
    {
        string faculty_ID;
        public Instructor(string name, int age, string faculty_ID) : base (name, age)
        {
            this.faculty_ID = faculty_ID;
        }

        public override void Talk(string Sentence)
        {
            base.Talk(Sentence);
        }

        public void Teach(string X)
        {
            Console.WriteLine("The teacher taught the teachable kids");
        }
    }

    public static void Main()
    {
        Student student = new Student("Kaiser", 18, "12345");
        Instructor instructor = new Instructor("Jhunfel", 22, "22332");

        student.Talk("Sir shot");
        instructor.Talk("G 5pm out ko!");
        instructor.Teach("x");
    }
}
