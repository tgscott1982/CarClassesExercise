using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassExercise;

public class Car
{
    
   public Car()
    {

    }
    
    public Car(string make, string model, int year) //parameterized class
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public Car(string make, string model, int year, bool used) //overloaded parameterized class
    {
        Make = make;
        Model = model;
        Year = year;
        this.Used = used;
    }

    public bool Used = true;   //field - declared/initialized

    public string Make { get; set; }    //properties - declared with get/set = read/write
    public string Model { get; set; }
    public int Year { get; set; }



    public void PrintCarInfoUsed()
    {
        Console.WriteLine("Car Information:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Used Status: {Used}");
    }

    public void PrintCarInfoNew()
    {
        Console.WriteLine("Car Information:");
        Console.WriteLine($"Make: {Make}");
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"Used Status: New");
    }










}
    
    
    
    

