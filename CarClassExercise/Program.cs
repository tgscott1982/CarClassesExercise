using CarClassExercise;

Car car1 = new Car();
car1.Make = "Chevy";
car1.Model = "Malibu";
car1.Year = 2020;
car1.Used = true;
Console.WriteLine($"The first car's info is {car1.Make}, {car1.Model}, {car1.Year}, Used: {car1.Used}.");
Console.WriteLine();

Car car2 = new Car("Toyota", "Prius", 2022);
car2.PrintCarInfoNew();
Console.WriteLine();



Car car3 = new Car() { Make = "Honda", Model = "Civic", Year = 2021, Used = true };
car3.PrintCarInfoUsed();
Console.WriteLine();
