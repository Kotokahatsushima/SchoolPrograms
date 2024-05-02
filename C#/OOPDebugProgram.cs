// See https://aka.ms/new-console-template for more information
using System;
using System.Threading;

class Building{
    
    //Class Variables
    private int floors;
    private int windows;
    private string roof_type;
    
    //Constructor
    public Building(int floors, int windows, string roof_type)
    {
        this.floors = floors;
        this.windows = windows;
        this.roof_type = roof_type;
    }
    
    //Accessor Method
    public int getFloors(){
        return floors;
    }
    public int getWindows(){
        return windows;
    }
    public string getRoof_Type(){
        return roof_type;
    }
    
    //Behaviors
    public void build(){
        Console.WriteLine("Building is Built!");
    }
    
    public void maintenance(){
        Console.WriteLine("Checking for cracks...");
    }
}

class School : Building {
    
    //Class Variables
    private int classrooms;
    
    //Constructor with base/super Constructor of Building
    public School(int floors, int windows, string roof_type, int classrooms)
                : base (floors, windows, roof_type)
    {
        this.classrooms = classrooms;
    }
    
    //Accessor Method
    public int getClassrooms(){
        return classrooms;
    }
}

class UC : School {
    
    //Inheritance
    private string name;
    
    //Constructor with base/super Constructor of Building and School
    public UC (int floors, int windows, string roof_type, int classrooms, string name)
            : base (floors, windows, roof_type, classrooms)
    {
        this.name = name;
    }
    
    //Accessor Method
    public string getName(){
        return name;
    }
    
    //Behaviors Line 83 -> Line 113
    public void announcement(){
        Console.WriteLine("Announcement: ");
    }
    
    // Example on using "has a" relationship
    public void startClass(Student student1){
        Console.WriteLine("Bell started ringing!");
        
        student1.enterClassroom(student1.getName());
    }
    
    // Example on using "has a" relationship
    public void endClass(Student student1){
        Console.WriteLine("Bell started ringing!");
        
        student1.leaveClassroom(student1.getName());
    }
    
    //Display UC's Information
    public void displayInformation(){
        Console.WriteLine("Welcome to " + getName() +
                            "\nWe have " + getFloors() + " floors, containing " + getClassrooms() + " classrooms each." +
                            "\nWe also have windows and " + getRoof_Type() + " top!\n");
    }
    
    //Display student's Users Information
    public void displayStudentInformation(Student student1){
        
        student1.displayStudent();
    }
}

class Human{
    
    //Class Variables
    private string name;
    private int age;
    private char sex;
    
    //Constructor
    public Human(string name, int age, char sex){
        this.name = name;
        this.age = age;
        this.sex = sex;
    }
    
    //Accessor Method
    public string getName(){
        return name;
    }
    
    public int getAge(){
        return age;
    }
    
    public char getSex(){
        return sex;
    }
    
    //Behaviors
    public void breathe(){
        Console.WriteLine("Breating...");
    }
    
    public void walk(){
        Console.WriteLine("Walking...");
    }
}

class Student : Human {
    
    //Class Variables
    private int yearLevel;
    
    //Constructor with base/super Constructor of Human
    public Student(string name, int age, char sex, int yearLevel)
                : base (name, age, sex)
    {
        this.yearLevel = yearLevel;
    }
    
    //Accessor Methods
    public int getYearLevel(){
        return yearLevel;
    }
    
    //Behaviors
    public void enterClassroom(string name){
        Console.WriteLine(name + " is entering the classroom...");
    }
    
    public void leaveClassroom(string name){
        Console.WriteLine(name + " is leaving Classroom...");
    }
    
    public void displayStudent(){
        Console.WriteLine("Students Information: " +
                            "\nName: " + getName() +
                            "\nAge: " + getAge() +
                            "\nSex: " + getSex() +
                            "\nYear Level: " + getYearLevel() + "\n");
    }
}


class Program {
  static void Main() {
    
    string name;
    int age, yearLevel;
    char sex, choice;
    
    //Instantiating delay time
    TimeSpan time = new TimeSpan(0,0,3);
    
    //Instantiating UC object
    UC uc_object = new UC(3, 4, "Flat Roof", 6, "UC");
    
    //User input for student
    Console.WriteLine("Kindly Fill out the Following Information: ");
    Console.Write("Name: ");
    name = Console.ReadLine();
    
    Console.Write("Age: ");
    age = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Sex: ");
    sex = Convert.ToChar(Console.ReadLine());
    
    Console.Write("Year Level: ");
    yearLevel = Convert.ToInt32(Console.ReadLine());
    
    //Instantiating Student object
    Student student_object = new Student(name, age, sex, yearLevel);

    uc_object.displayInformation();
    
    //Start of Class
    Console.WriteLine();
    uc_object.startClass(student_object);
    student_object.walk();
    Thread.Sleep(time);
    
    Retry:
    //View Student Information
    Console.Write("\nDo you want to view the student?(Y/N): ");
    choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
    
    if(choice == 'Y'){
        uc_object.displayStudentInformation(student_object);
    }
    else if (choice == 'N'){
        Console.WriteLine("ok, Press any key to continue.");
        Console.ReadKey();
    }
    else{
        Console.WriteLine("invalid input!");
        goto Retry;
    }
    
    //endClass of Class
    Console.WriteLine();
    uc_object.endClass(student_object);
    student_object.walk();
    Thread.Sleep(10);
  }
}
