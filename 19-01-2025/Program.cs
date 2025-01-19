////////////////////task 1//////////////////
// System.Console.WriteLine("Введите первое число:");
// System.Console.Write("> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число:");
// System.Console.Write("> ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите третье число:");
// System.Console.Write("> ");
// int c = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Результаты:");
// System.Console.Write("Сумма чисел: ");
// System.Console.WriteLine(a+b+c);
// System.Console.Write("Самое большое число: ");
// int ma=Math.Max(a,b);
// int max = Math.Max(ma,c);
// System.Console.WriteLine(max);
// System.Console.Write("Самое маленькое число: ");
// int mi=Math.Min(a,b);
// int min = Math.Min(ma,c);
// System.Console.WriteLine(min);
////////////////task 2///////////////////////
// System.Console.Write("> ");
// int num=Convert.ToInt32(Console.ReadLine());
// int []arr = new int [num];
// for (int i = 0; i < arr.Length; i++)
// {
//     System.Console.Write("> ");
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// System.Console.WriteLine("Результаты:");
// int cnt=0;
// int cnt2=0;
// int sum=0;
// for (int i = 0; i < arr.Length; i++)
// {
//  if(0<arr[i]){
//    sum+=arr[i];
//    }
//    if (arr[i]%2==0){
//     cnt++;
//    } 
//    else if(arr[i]%2!=0){
//     cnt2++;
//    }

// }
// System.Console.Write("Количество четных чисел: ");
// System.Console.WriteLine(cnt);
// System.Console.Write("Количество нечетных чисел: ");
// System.Console.WriteLine(cnt2);
// System.Console.Write("Сумма положительных чисел: ");
// System.Console.WriteLine(sum);
/////////////////task 3////////////////////////
// System.Console.WriteLine("Введите два числа:");
// System.Console.Write("> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("> ");
// int b = Convert.ToInt32(Console.ReadLine());
// void Printnum(int num){
//     if(num%2==0){
//         System.Console.WriteLine($"Число {num} является четным");
//     }
//     else {
//         System.Console.WriteLine($"Число {num} является нечетным");
//     }

// }
// int sum(int a,int b){
//     return a+b;
// }
// int max(int a,int b){
//     if(a>b){
//         return a;
//     }
//     else{return b;}
// }
// System.Console.WriteLine("Результаты:");
// Printnum(a);
// Printnum(b);
// System.Console.WriteLine("Сумма чисел: " + sum(a,b));
// System.Console.WriteLine($"Максимальное число: {max(a,b)}");
//////////////////task 4///////////////////////
// Piggy my = new Piggy();
// System.Console.Write("Add money:");
// int a = Convert.ToInt32(Console.ReadLine());
// my.Add(a);
// System.Console.Write("Take money:");
// int b = Convert.ToInt32(Console.ReadLine());
// my.Take(b);
// my.Show();

// class Piggy
// {
//     public int Money;
//     public void Add(int amount){
//         Money+=amount;
//     }
//     public void Take(int amount){
//         Money-=amount;
//     }
//     public void Show(){
//         System.Console.WriteLine($"In a Piggy: {this.Money}");
//     }
// }
///////////////task 5/////////////////////
// System.Console.WriteLine("Создаем кошку...");
// System.Console.Write("Имя:");
// string name =Console.ReadLine(); 
// System.Console.Write("Возраст: ");
// int age = Convert.ToInt32(Console.ReadLine());
// Cat Leo = new Cat(name,age);
// Leo.Say();
// Leo.ShowInfo();
// class Cat
// {
//   public string Name;
//   public int Age;
//   public Cat (string name, int age){
//     Name=name;
//     Age=age;
//   }    
//    public void Say(){
//     System.Console.WriteLine("Cat says C# is tooop!");
//    }
//    public void ShowInfo(){
//     System.Console.WriteLine("Информация о кошке:");
//     System.Console.WriteLine($"Кошка {Name}, возраст: {Age} года");
//    }
// }
///////////////task 6////////////////
// Calculator Soft = new Calculator();
// System.Console.WriteLine("Калькулятор:");
// System.Console.Write("> ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("> ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Результаты:");
// System.Console.WriteLine($"{a} + {b} = {Soft.Add(a,b)}");
// System.Console.WriteLine($"{a} - {b} = {Soft.Substract(a,b)}");
// System.Console.WriteLine($"{a} * {b} = {Soft.Multiply(a,b)}");

// class Calculator
// {
//      public int Add(int a,int b){
//         return a+b;
//      }
//      public int Substract(int a,int b){
//         return a-b;
//      }
//      public int Multiply(int a,int b){
//         return a*b;
//      }
// }
///////////////////task 7//////////////
// System.Console.WriteLine("Создаем книгу...");
// System.Console.Write("Название:");
// string name = Console.ReadLine();
// System.Console.Write("Автор:");
// string author = Console.ReadLine();
// System.Console.Write("Год издания:");
// int year = Convert.ToInt32(Console.ReadLine());
// Book After = new Book(name,author,year);
// System.Console.WriteLine();
// After.ShowInfo();
// System.Console.Write("Эта книга издана позже 1800 года? ");
// if(After.IsNewBook(year)==true){
//     System.Console.Write("Да");
// }
// else {System.Console.Write("Нет");}

// class Book
// {
//     public string Title;
//     public string Author;
//     public int Year;

// public Book(string title,string author, int year){
//     Title=title;
//     Author=author;
//     Year=year;
// }
// public void ShowInfo(){
//     System.Console.WriteLine("Информация о книге:");
//     System.Console.WriteLine($"Книга: {Title} ");
//     System.Console.WriteLine($"Автор: {Author} ");
//     System.Console.WriteLine($"Год издания: {Year} ");
// }
// public bool IsNewBook(int year){
//     if(year>1800){
// return true;
//     }
//     else return false;
// }

// }
////////////////task 8/////////////////
// System.Console.WriteLine("Создаем товар...");
// System.Console.Write("Название: ");
// string name = Console.ReadLine();
// System.Console.Write("Цена: ");
// int price = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Количество: ");
// int count = Convert.ToInt32(Console.ReadLine());
// Product Apple = new Product(name,price,count);
// System.Console.Write("Сколько добавить?:");
// int a = Convert.ToInt32(Console.ReadLine());
// Apple.Add(a);
// System.Console.Write("На складе осталось: ");
// Apple.ShowInfo();
// System.Console.Write("Сколько взять?:");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("На складе осталось: ");
// Apple.Sell(b);
// Apple.ShowInfo();
// class Product
// {
//     public string Name;
//     public int Price;
//     public int Count;

//     public Product(string name,int price,int count){
//      Name=name;
//      Price=price;
//      Count=count;
//     }
//     public void Sell(int amount){
//         Count-=amount;
//     }
//     public void Add(int amount){
//         Count+=amount;
//     }
//     public void ShowInfo(){
//         System.Console.WriteLine(Count);
//     }
// }
///////////////////task 9/////////////////
System.Console.WriteLine("Создаем студента...");
System.Console.Write("Имя: ");
string name =Console.ReadLine();
Student bezhan = new Student(name);
bezhan.AddGrade()
class Student
{
    public string Name;
    public int[] Grades;

    public Student(string name){
        Name=name;
    } 
    public void AddGrade(int grade){
        for (int i = 0; i < grade; i++)
        {
            Grades[i]=Convert.ToInt32(Console.ReadLine());
        }
    }
    public double GetAverage(){
        int cnt=0;
        int sum=0;
        for (int i = 0; i < Grades.Length; i++)
        {
            sum+=Grades[i];
            cnt++;
        }
        return sum/cnt;
    }
    public void ShowGrades(){
        System.Console.WriteLine("Информация о студенте:");
        System.Console.WriteLine($"Студент: {Name}");
        System.Console.WriteLine($"Оценки:");
        int jk=0;
        for (int i = 0; i < Grades.Length; i++)
        {
            System.Console.Write(Grades[i]);
            if(jk==Grades.Length){
                System.Console.Write(",");
            }
            jk++;
        }
        System.Console.Write("Средний балл: " + GetAverage());
    }
}