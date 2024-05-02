using System;
class Fan 
{
    private int speed;
    private string color;
    private bool power;
   //constructor
   
    public Fan()
    {
        this.speed = 0;
        this.color = "";
        this.power = false;
    }
    
    
    //Setters
    public void setSpeed(int speed)
    {
        this.speed = speed;
    }
    
    
    public void setColor(string color)
    {
        this.color = color;
    }
    
    
    public void setPower(bool power)
    {
        this.power = power;
    }
    

//Accessor
    public string getSpeed()
    {
        switch(speed)
        {
            case 1:
                return "Slow";
            case 2:
                return "Medium";
            case 3:
                return "Fast";
            default:
                return "";
        }
    }
    
    
    public string getColor()
    {
        return color;
    }
    
    
    public string getPower()
    {
        if(power) 
        {
            return "on";
        } 
        else 
        {
            return "off";
        }
    }


//print all info
    public void displayAll()
    {
        Console.WriteLine("The speed of the fan is: " + getSpeed());
        Console.WriteLine("The color of the fan is: " + getColor());
        Console.WriteLine("The power of the fan is: " + getPower());
    }

    
    
  static void Main() 
  {
    Fan myFan = new Fan();
    myFan.setSpeed(1);
    myFan.setColor("Blue");
    myFan.setPower(true);
    
    Fan mysecondFan = new Fan();
    mysecondFan.setSpeed(3);
    mysecondFan.setColor("Pink");
    mysecondFan.setPower(false);
    
    
    Console.WriteLine("Fan 1");
    myFan.displayAll();
    Console.WriteLine("\nFan 2");
    mysecondFan.displayAll();
  }
}
