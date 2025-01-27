using System.Formats.Asn1;

namespace Infrastructure;

public class Manegment
{
  public List<Author> authors = new List<Author>(3);
  public List<Car> cars = new List<Car>();
  public List<Car> GetCarsByFilter = new List<Car>();
public void Add(Author author){
        authors.Add(author);
}
    public void ShowAuthor(){
        foreach (var student in authors)
        {
        System.Console.WriteLine($"Name = {student.Name} Age = {student.Age} Email = {student.Email}");
        }
    }

    public void FindAuthors(){
        int cnt = 1 ;
        foreach (var student in authors)
        {
            if (student.Age>25 && student.HasCar )
            {
                System.Console.WriteLine($"{cnt}. {student.Name} ({student.Age})");
            
            cnt++;
            }
        }
    }

    public void FindAuthorsByEmail(string email){
      foreach (var student in authors)
      {
      
        if (email==student.Email)
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Найден автор:");
            System.Console.WriteLine($"Имя: {student.Name}");
            System.Console.WriteLine($"Возраст: {student.Age}");
            System.Console.WriteLine($"Email: {student.Email}");
        }
        
      }

    }
public void AddCars(Car car){
        cars.Add(car);
}

    public bool AddCar(Car item){
        if (item.Year<2026 && item.Price >0 && item.Type=="Sedan" || item.Type=="SUV" || item.Type=="Sport")
        {
            return true;
        }
        else{
            return false;
        }
      }



      
    }


