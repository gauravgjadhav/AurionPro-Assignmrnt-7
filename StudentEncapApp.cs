using System;
using StudentEncapApp.Model;
class program
{
    public static void Main(string[] args)
    {
        Student stud;
        stud = new Student();
        stud.SetName("Ram");
        stud.SetCgpa(5.6);
        stud.SetRollno(1001);
        Console.WriteLine("The name is {0}\nThe CGPA is {1}\nThe roll no is {2}\nThe CGPA percentage is {3}%",stud.GetName(),stud.GetCgpa(),stud.GetRillno(),stud.CgpaPecentage());

    }
}