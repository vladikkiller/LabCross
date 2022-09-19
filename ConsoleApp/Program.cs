// See https://aka.ms/new-console-template for more information
using VladLib;

//Створення об'єктів
People valik = new People(32, "man", 1.85, 75, "Ukraine", "atheism", "medic", 145324);
Student petro = new Student(21, "woman", 1.71, 72, "Ukraine", "christianity", "computer engineer", 123472, 433456, "CS 41");
Worker ivan = new Worker(45, "man", 1.91, 92, "Azerbaijan", "islam", "teacher", 223888, "director", "applied sciences");

//Виклик методія для об'єкта класу People
Console.WriteLine("-----class People-----");
valik.Print();
valik.indexImt();

//Виклик методія для об'єкта класу Student
Console.WriteLine("-----class Student-----");
petro.PrintStudent();
petro.indexImt();

//Виклик методія для об'єкта класу Worker
Console.WriteLine("-----class Worker-----");
ivan.PrintWorker();
ivan.indexImt();

Console.ReadKey();