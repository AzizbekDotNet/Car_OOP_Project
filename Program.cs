using Classes;
using System.Diagnostics;

Console.WriteLine("\t\tMashina ma'lumotlarini kiriting");
Console.Write("Mashina markasini kiriting: ");
string marka = Console.ReadLine();
Console.Write("Mashina modelini kiriting: ");
string model = Console.ReadLine();
Console.Write("Mashina yilini kiriting: ");
int year = int.Parse(Console.ReadLine());
Console.Write("Mashina narxini kiriting: ");
decimal price = Convert.ToDecimal(Console.ReadLine());
Console.Write("Mashina tezligini kiriting: ");
decimal speed = Convert.ToDecimal(Console.ReadLine());
Car car = new Car(model,year,price,speed);
car.Marka = marka;

Console.WriteLine(car.GetCarInfo());

Console.Write("Hozirgi yilni kiriting: ");
int nowyear = int.Parse(Console.ReadLine());
Console.WriteLine($"Mashinaning hozirgi narxi: {car.CalculateDepreciation(nowyear - year)}");

