namespace Infostructure;

public class Library
{
    public List<Student> Students { get; set; } = new List<Student>();
    public List<Book> Books { get; set; } = new List<Book>();


    public void PrintStudents()
    {
        int cnt = 0;
        System.Console.WriteLine("Список всех студентов:");
        foreach (var item in Students)
        {
            System.Console.WriteLine($"Студент: {item.Name}, Возраст = {item.Age},  Группа: {item.Group} ");
            cnt++;
        }
        System.Console.WriteLine($"Всего студентов: {cnt}");
    }
    public void FindByGroup(string group)
    {
        int cnt = 0;
        System.Console.WriteLine($"=== Поиск студентов группы {group}  ===");
        foreach (var item in Students)
        {
            if (item.Group == group)
            {
                System.Console.WriteLine($"Найден студент: {item.Name} из группы: {item.Group} ");
                cnt++;

            }
        }
        System.Console.WriteLine($"Всего найдено: {cnt} студента");
    }

    public void GetAverage()
    {
        double sum = 0;
        double cnt = 0;
        foreach (var item in Students)
        {
            sum += item.Age;
            cnt++;
        }
        System.Console.WriteLine($"Количество студентов: {cnt}");
        System.Console.WriteLine($"Средний возраст: {sum / cnt}");
    }
    public void FindYoungest()
    {
        int min = 99;
        foreach (var item in Students)
        {
            if (item.Age < min)
            {
                min = item.Age;
            }
            System.Console.WriteLine($"Самый молодой: {item.Name} ({min} лет)");
            break;
        }
    }

    public void FliterByAge(int n1, int n2)
    {
        int cnt = 1;
        foreach (var item in Students)
        {
            if (item.Age == n1 || item.Age == n2)
            {
                System.Console.WriteLine($"{cnt}. {item.Name}, {item.Age} лет, Группа: {item.Group}");
            }
            cnt++;
        }

    }

    public void Addbook(Book book)
    {
        if (book.Year < 2025 && book.Author.Length > 3 && book.Title.Length > 3)
        {
            System.Console.WriteLine($"Книга ({book.Title}) успешно добавлена");
        }
        else
        {
            System.Console.WriteLine("Книга не добавлена");
        }

    }

public void FindByYear(int Year){
foreach (var item in Books)
{
    if (Year==item.Year)
    {
        System.Console.WriteLine($"{item.Title} - {item.Author}");
    }
    else{
        System.Console.WriteLine("Нет книг такого года происхождения");
    }
}

}

public void CountBooksByAuthor(string Author){
    int cntall = 0;
    int cntIs = 0;
    int cntGet = 0;

    foreach (var item in Books)
    {
        if (item.Author==Author)
        {
               cntall++; 
        }
        if(Author==item.Author && item.IsAvailable!=false){
            cntIs++;
        }
        if(Author==item.Author && item.IsAvailable==false){
            cntGet++;
        }

    }
        System.Console.WriteLine($"Всего книг: {cntall}");
        System.Console.WriteLine($"Доступно: {cntIs}");
        System.Console.WriteLine($"В пользовании: {cntGet}");
}

public void ChangeStatus(string title,bool IsAvailable){
foreach (var item in Books)
{
    if (item.Title==title && item.IsAvailable==true)
    {
        item.IsAvailable=IsAvailable;
System.Console.WriteLine($"Книга {item.Title} теперь недоступна");
    }
    else if (title!=item.Title)
    {
        System.Console.WriteLine("ERR0R!!!");
    }
    else
    {
        System.Console.WriteLine($"Книга {item.Title} теперь доступна");
    }
}
}

public void ShowLibrary(){
    int student=0;
    int book = 0 ;
    int bookagree = 0 ;
    int bn = 0;
foreach (var item in Students)
{
    if (item.Name==item.Name)
    {
    student++;
    }
}
foreach (var item in Books)
{
    if (item.Author==item.Author)
    {
    book++;
    }
}
foreach (var item in Books)
{
    if (item.IsAvailable==true)
    {
    bookagree++;
    }
    else {
 bn ++;
    }
}
System.Console.WriteLine($"Всего студентов:{student}");
System.Console.WriteLine($"Всего книг:{book}");
System.Console.WriteLine($"Доступно книг:{bookagree}");
System.Console.WriteLine($"Книг в пользовании::{bn}");
}
}
