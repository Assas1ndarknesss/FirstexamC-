using System.Security.Cryptography;
using Infrastructure;

// Author A1 = new Author();
// System.Console.Write("Name:");
// A1.Name = Console.ReadLine();
// System.Console.Write("Age:");
// A1.Age =Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Email:");
// A1.Email =Console.ReadLine();

// Author A2 = new Author();
// System.Console.Write("Name:");
// A2.Name = Console.ReadLine();
// System.Console.Write("Age:");
// A2.Age =Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Email:");
// A2.Email =Console.ReadLine();

// Author A3 = new Author();
// System.Console.Write("Name:");
// A3.Name = Console.ReadLine();
// System.Console.Write("Age:");
// A3.Age =Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Email:");
// A3.Email =Console.ReadLine();
// A3.HasCar = true;

Manegment manager = new Manegment();
// manager.Add(A1);
// // manager.Add(A2);
// manager.Add(A3);

// // manager.ShowAuthor();
// // manager.FindAuthors();
// System.Console.Write("Who do you need?:");
// string email = Console.ReadLine();
// manager.FindAuthorsByEmail(email);
Car car = new Car();
System.Console.Write("Brand:");
car.Brand = Console.ReadLine();
System.Console.Write("Model:");
car.Model = Console.ReadLine();
System.Console.Write("Year:");
car.Year = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Price:");
car.Price = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Type:");
car.Type = Console.ReadLine();
manager.AddCars(car);
if (manager.AddCar(car)==false)
{
    System.Console.WriteLine("Ошибка: некорректные данные машины");
    System.Console.WriteLine("Результат: false");
}
else{
    System.Console.WriteLine("Машина успешно добавлена");
    System.Console.WriteLine("Результат: true");
}
