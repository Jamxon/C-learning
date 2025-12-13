using System;
using System.Security.Cryptography;
using School.Domain.Models;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student("Jamshidbek", "Aliyev", 20);
        Console.Write("Student info: ");
        student.PrintInfo();
        var teacher = new Teacher("Nodirxon", "Abdumurotov", 25);
        Console.Write("Teacher info: ");
        teacher.PrintInfo();
    }
}
