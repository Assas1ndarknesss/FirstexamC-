﻿using Infostructure;

Library library = new Library();

// Student student = new Student();
// System.Console.Write("Name:");
// string name = Console.ReadLine();
// System.Console.Write("Age:");
// int age = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Group:");
// string group = Console.ReadLine();
// System.Console.Write("Name:");
// string name2 = Console.ReadLine();
// System.Console.Write("Age:");
// int age2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Group:");
// string group2 = Console.ReadLine();
// library.Students.Add(new Student { Name = name, Age = age, Group = group });
// library.Students.Add(new Student { Name = name2, Age = age, Group = group2 });
// library.PrintStudents();     ///hamai talabaho
// System.Console.Write("Найти по группе:");
// string group1 = Console.ReadLine() ;
// library.FindByGroup(group1);
// library.GetAverage(); //// average
// library.FindYoungest();
// System.Console.Write("Filter of:");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Filter to:");
// int b = Convert.ToInt32(Console.ReadLine());
// library.FliterByAge(a,b);
Book book = new Book();
System.Console.Write($"Title:");
string tit = Console.ReadLine();
book.Title=tit;
System.Console.Write($"Author:");
string aut = Console.ReadLine();
book.Author=aut;
System.Console.Write($"Year:");
int Year = Convert.ToInt32(Console.ReadLine());
book.Year=Year;
book.IsAvailable = false;
// Book book3 = new Book();
// System.Console.Write($"Title:");
// string tit3 = Console.ReadLine();
// book3.Title=tit;
// System.Console.Write($"Author:");
// string aut3 = Console.ReadLine();
// book3.Author=aut;
// System.Console.Write($"Year:");
// int Year3 = Convert.ToInt32(Console.ReadLine());
// book3.Year=Year;
// book3.IsAvailable = true;
// Book book4 = new Book();
// System.Console.Write($"Title:");
// string tit4 = Console.ReadLine();
// book4.Title=tit;
// System.Console.Write($"Author:");
// string aut4 = Console.ReadLine();
// book4.Author=aut;
// System.Console.Write($"Year:");
// int Year4 = Convert.ToInt32(Console.ReadLine());
// book4.Year=Year;
// book4.IsAvailable = true;
library.Books.Add(book);
// library.Books.Add(book3);
// library.Books.Add(book4);
System.Console.Write("Search year:");
int ye = Convert.ToInt32(Console.ReadLine());
// library.FindByYear(ye);
System.Console.Write("Search Author:");
string Author1 = Console.ReadLine();
// library.CountBooksByAuthor(Author1);
System.Console.Write("Change book which?");
string a = Console.ReadLine();
System.Console.WriteLine("With what you want change: (true or false)");
System.Console.Write("Your choose:");
bool b = Convert.ToBoolean(Console.ReadLine());
library.ChangeStatus(a,b);
